using Global;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Objets_BD
{
    public class Joueur : IComparable<Joueur>
    {
        private Dictionary<Categorie, int> Pointage { get; set; }

        public string AliasJoueur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        /// <summary>Est lancé quand un des pointage du joueur est modifié</summary>
        public EventHandler PointageChange { get; set; }
        
        public Joueur()
        {
            Pointage = new Dictionary<Categorie, int>();
        }

        public int CalculerPointageTotal()
        {
            int total = 0;
            foreach(var pair in Pointage)
            {
                total += pair.Value;
            }
            return total;
        }

        public static int CalculerPointageTotal(List<Joueur> joueurs)
        {
            int total = 0;
            foreach (var joueur in joueurs)
            {
                total += joueur.CalculerPointageTotal();
            }
            return total;
        }

        public void AjouterPointage(Categorie seraAssociee, int pointageInitial)
        {
            Pointage.Add(seraAssociee, pointageInitial);
        }

        /// <summary>Retourne un pointage associé à une certaine catégorie</summary>
        public int this[Categorie key]
        {
            get { return Pointage[key]; }
            set
            {
                if (value <= Categorie.GAGNER_NBPOINTS)
                {
                    Pointage[key] = value;
                    PointageChange?.Invoke(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show(this.AliasJoueur + " ne peut pas gagner plus de points en " + key.Nom);
                }
            }
        }

        public int CompareTo(Joueur compareJoueur)
        {
            if (compareJoueur == null)
                return 1;
            else
                return -this.CalculerPointageTotal().CompareTo(compareJoueur.CalculerPointageTotal());
        }

        public override string ToString()
        {
            return AliasJoueur;
        }

        /// <summary>
        /// Incrémente le score du joueur pour une catégorie et met le flag gagnee à true dans la base de donnée
        /// </summary>
        public void IncrScore(Categorie gagnee)
        {
            try
            {
                OracleCommand command = new OracleCommand("STATISTIQUES.IncrScore", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("P_codeCategorie", OracleDbType.Varchar2, gagnee.CodeCategorie, ParameterDirection.Input),
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, this.AliasJoueur, ParameterDirection.Input)
                );
                command.ExecuteNonQuery();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show(sqlExcept.Message);
            }
        }

        /// <summary>
        /// Retourne les scores du joueur pour chaque catégories
        /// </summary>
        public Dictionary<Categorie, int> GetScores()
        {
            Dictionary<Categorie, int> resultat = new Dictionary<Categorie, int>();

            try
            {
                OracleCommand command = new OracleCommand("STATISTIQUES.GetScoresJoueur", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("resultat", OracleDbType.RefCursor, ParameterDirection.ReturnValue),
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, this.AliasJoueur, ParameterDirection.Input)
                );

                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    Categorie categorie = DBGlobal.Categories.Find(c => c.CodeCategorie == reader.GetString(0));
                    int score = reader.GetInt32(0);
                    resultat.Add(categorie, score);
                }
                reader.Close();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show(sqlExcept.Message);
            }

            return resultat;
        }

        /// <summary>
        /// Retourne les catégories gagnées par le joueur
        /// </summary>
        public List<Categorie> GetCategoriesGagnees()
        {
            List<Categorie> resultat = new List<Categorie>();

            try
            {
                OracleCommand command = new OracleCommand("STATISTIQUES.GetCategoriesGagnees", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("resultat", OracleDbType.RefCursor, ParameterDirection.ReturnValue),
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, this.AliasJoueur, ParameterDirection.Input)
                );

                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Categorie categorie = DBGlobal.Categories.Find(c => c.Nom == reader.GetString(0));
                    resultat.Add(categorie);
                }
                reader.Close();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show(sqlExcept.Message);
            }

            return resultat;
        }

        /// <summary>
        /// Retourne la catégorie la plus faible du joueur
        /// </summary>
        public Categorie GetCategorieFaible()
        {
            Categorie resultat = null;

            try
            {
                OracleCommand command = new OracleCommand("STATISTIQUES.GetCategorieFaible", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("resultat", OracleDbType.RefCursor, ParameterDirection.ReturnValue),
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, this.AliasJoueur, ParameterDirection.Input)
                );

                OracleDataReader reader = command.ExecuteReader();
                reader.Read();
                resultat = DBGlobal.Categories.Find(c => c.CodeCategorie == reader.GetString(0));
                reader.Close();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show(sqlExcept.Message);
            }

            return resultat;
        }

        /// <summary>
        /// Enlève le joueur de la base de donnée
        /// </summary>
        public void Supprimer()
        {
            try
            {
                OracleCommand command = new OracleCommand("GESTIONJOUEURS.SupprJoueur", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, this.AliasJoueur, ParameterDirection.Input)
                );
                command.ExecuteNonQuery();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show(sqlExcept.Message);
            }
        }

        /// <summary>
        /// Ajoute le joueur à la base de donnée
        /// </summary>
        /// <exception cref="ArgumentException">Certaines propriétés du joueur sont null</exception>
        public void Ajouter()
        {
            // Vérifier que toute les propriétés du joueur sont valide
            if (this.AliasJoueur == null || this.Nom == null || this.Prenom == null)
            {
                throw new ArgumentException("Certaines propriétés du joueur sont null");
            }

            try
            {
                OracleCommand command = new OracleCommand("GESTIONJOUEURS.InsertJoueur", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, this.AliasJoueur, ParameterDirection.Input),
                    new OracleParameter("P_nom", OracleDbType.Varchar2, this.Nom, ParameterDirection.Input),
                    new OracleParameter("P_prenom", OracleDbType.Varchar2, this.Prenom, ParameterDirection.Input)
                );
                command.ExecuteNonQuery();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show(sqlExcept.Message);
            }
        }

        /// <summary>
        /// Retourne la totalité des joueurs de la base de donnée
        /// </summary>
        public static List<Joueur> ChargerTous()
        {
            List<Joueur> resultat = new List<Joueur>();

            try
            {
                OracleCommand command = new OracleCommand("GESTIONJOUEURS.GetTousJoueurs", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("resultat", OracleDbType.RefCursor, ParameterDirection.ReturnValue)
                );

                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Joueur joueur = new Joueur()
                    {
                        AliasJoueur = reader.GetString(0),
                        Nom = reader.GetString(1),
                        Prenom = reader.GetString(2)
                    };
                    resultat.Add(joueur);
                }
                reader.Close();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show(sqlExcept.Message);
            }

            return resultat;
        }
    }
}
