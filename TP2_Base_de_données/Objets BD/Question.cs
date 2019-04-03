using Global;
using Objets_BD;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Objets_BD
{
    public class Question
    {
        public const int NB_REPONSES = 4;
        /// <summary>Le nombre de points gagnés par bonne réponse</summary>
        public const int POINTS_REPONSE = 1;

        private Reponse[] _Reponses { get; set; }

        public string NumQuestion { get; private set; }
        public string Enonce { get; set; }
        public Categorie Categorie { get; set; }
        public Reponse[] Reponses { get => _Reponses; set => SetReponses(value); }

        public Question()
        {
            _Reponses = new Reponse[NB_REPONSES];
        }

        private void SetReponses(Reponse[] valeur)
        {
            _Reponses = valeur;
            _Reponses = _Reponses.OrderBy(r => r.NumReponse).ToArray();
        }

        #region Requêtes BD
        /// <summary>
        /// Charge les réponses depuis la base de donnée
        /// </summary>
        public void ChargerReponses()
        {
            try
            {
                OracleCommand command = new OracleCommand("GESTIONQUESTIONS.GetReponses", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("resultat", OracleDbType.RefCursor, ParameterDirection.ReturnValue),
                    new OracleParameter("P_numQuestion", OracleDbType.Varchar2, 20, this.NumQuestion, ParameterDirection.Input)
                );

                OracleDataReader reader = command.ExecuteReader();
                for (int i = 0; reader.Read(); ++i)
                {
                    Reponses[i] = new Reponse()
                    {
                        NumReponse = reader.GetString(0),
                        Description = reader.GetString(1),
                        EstBonne = (reader.GetString(2) == "Y"),
                        Question = this
                    };
                }
                _Reponses = Reponses.OrderBy(r => r.NumReponse).ToArray();
                reader.Close();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Question.ChargerReponses : " + sqlExcept.Message);
            }
        }

        /// <summary>
        /// Met le flag repondu de la question à vrai dans la base de donnée (la questions ne pourra donc plus être prise aux hasard)
        /// </summary>
        public void Repondre()
        {
            try
            {
                OracleCommand command = new OracleCommand("GESTIONQUESTIONS.SetRepondu", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("P_numQuestion", OracleDbType.Varchar2, 20, this.NumQuestion, ParameterDirection.Input),
                    new OracleParameter("P_nouvRepondu", OracleDbType.Char, 1, "Y", ParameterDirection.Input)
                );
                command.ExecuteNonQuery();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Question.Repondre : " + sqlExcept.Message);
            }
        }

        /// <summary>
        /// Ajoute la question à la base de donnée (<see cref="NumQuestion"/> sera changé par un ID unique attribué par la base de donnée)
        /// </summary>
        /// <exception cref="ArgumentException">Certaines propriétés de la question sont null</exception>
        public void Ajouter()
        {
            // Vérifier que toute les propriétés de la question sont valide
            if (this.Enonce == null || this.Categorie == null || this.Reponses.Any(r => r == null))
            {
                throw new ArgumentException("Certaines propriétés de la question sont null");
            }

            try
            {
                OracleCommand command = new OracleCommand("GESTIONQUESTIONS.InsertQuestion", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("P_numQuestion", OracleDbType.Varchar2, 20, OracleCollectionType.None, ParameterDirection.InputOutput),
                    new OracleParameter("P_enonce", OracleDbType.Clob, this.Enonce, ParameterDirection.Input),
                    new OracleParameter("P_codeCategorie", OracleDbType.Char, 1, this.Categorie.CodeCategorie, ParameterDirection.Input)
                );

                command.ExecuteNonQuery();
                this.NumQuestion = command.Parameters["P_numQuestion"].Value.ToString();

                foreach (var reponse in this.Reponses)
                {
                    reponse.NumReponse = this.NumQuestion + reponse.NumReponse;
                    reponse.Ajouter();
                }
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Question.Ajouter : " + sqlExcept.Message);
            }
        }

        /// <summary>
        /// Remet le flag repondu de toute les questions à faux dans la base de donnée
        /// </summary>
        public static void ResetQuestionsRepondues()
        {
            try
            {
                OracleCommand command = new OracleCommand("GESTIONQUESTIONS.ResetQuestionsRepondues", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Question.ResetQuestionsRepondues : " + sqlExcept.Message);
            }
        }

        /// <summary>
        /// Retourne une question au hasard faisant partie d'une certaine catégorie et dont le flag repondu est faux
        /// </summary>
        public static Question GetQuestionHasard(Categorie categorie)
        {
            Question resultat = null;

            try
            {
                OracleCommand command = new OracleCommand("GESTIONQUESTIONS.GetQuestionHasard", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("resultat", OracleDbType.RefCursor, ParameterDirection.ReturnValue),
                    new OracleParameter("P_codeCategorie", OracleDbType.Char, 1, categorie.CodeCategorie, ParameterDirection.Input)
                );

                OracleDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    resultat = new Question() { NumQuestion = reader.GetString(0), Enonce = reader.GetString(1), Categorie = categorie };
                }
                reader.Close();

                resultat.ChargerReponses();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Question.GetQuestionHasard : " + sqlExcept.Message);
            }

            return resultat;
        }
        #endregion
    }
}
