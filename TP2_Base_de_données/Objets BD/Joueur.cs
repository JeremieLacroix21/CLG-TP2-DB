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
        public const int NB_JOUEURS_MAX = 4, NB_JOUEURS_MIN = 2;

        private Dictionary<Categorie, int> _Pointage { get; set; }

        #region Éléments de PointageChange(EventHandler)
        private List<EventHandler> _Delegates_PointageChange { get; set; }
        private EventHandler _PointageChange { get; set; }
        /// <summary>Est lancé quand un des pointage du joueur est modifié</summary>
        public event EventHandler PointageChange {
            add {
                _PointageChange += value;
                _Delegates_PointageChange.Add(value);
            }
            remove {
                _PointageChange -= value;
                _Delegates_PointageChange.Remove(value);
            }
        }
        #endregion

        public string AliasJoueur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        
        public Joueur()
        {
            _Pointage = new Dictionary<Categorie, int>();
            _Delegates_PointageChange = new List<EventHandler>();
        }

        #region Methodes Pointages
        /// <summary>
        /// Retourne la somme des pointages du joueur toutes catégories confondues
        /// </summary>
        public int CalculerPointageTotal()
        {
            int total = 0;
            foreach(var pair in _Pointage)
            {
                total += pair.Value;
            }
            return total;
        }

        /// <summary>
        /// Retourne la somme des pointages de joueurs toutes catégories confondues
        /// </summary>
        public static int CalculerPointageTotal(List<Joueur> joueurs)
        {
            int total = 0;
            foreach (var joueur in joueurs)
            {
                total += joueur.CalculerPointageTotal();
            }
            return total;
        }

        /// <summary>
        /// Remet tous les points à 0
        /// </summary>
        public void ResetPointage()
        {
            foreach (var categorie in DBGlobal.Categories)
            {
                if (_Pointage.ContainsKey(categorie))
                    _Pointage[categorie] = 0;
            }
        }

        /// <summary>
        /// Ajoute une "case" au pointage du joueur pour une certaine catégorie
        /// </summary>
        public void AjouterPointage(Categorie seraAssociee, int pointageInitial = 0)
        {
            if (!_Pointage.ContainsKey(seraAssociee))
                _Pointage.Add(seraAssociee, pointageInitial);
        }

        /// <summary>
        /// Désinscrit toutes les méthodes inscrites à PointageChange
        /// </summary>
        public void ClearPointageChange()
        {
            foreach (var e in _Delegates_PointageChange)
            {
                _PointageChange -= e;
            }
            _Delegates_PointageChange.Clear();
        }
        #endregion

        /// <summary>
        /// Retourne un pointage associé à une certaine catégorie
        /// </summary>
        public int this[Categorie key]
        {
            get { return _Pointage[key]; }
            set
            {
                if (value <= Categorie.GAGNER_NBPOINTS)
                {
                    _Pointage[key] = value;
                    _PointageChange?.Invoke(this, new EventArgs());
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

        /// <summary>
        /// Retourne les catégories gagnées par le joueur sans faire de requête à la base de donnée
        /// </summary>
        public List<Categorie> GetCategoriesGagnees_Local()
        {
            List<Categorie> gagnees = new List<Categorie>();
            foreach (var pair in _Pointage)
            {
                if (pair.Value == Categorie.GAGNER_NBPOINTS)
                    gagnees.Add(pair.Key);
            }
            return gagnees;
        }

        #region Requêtes BD
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
                    new OracleParameter("P_codeCategorie", OracleDbType.Char, 1, gagnee.CodeCategorie, ParameterDirection.Input),
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, 20, this.AliasJoueur, ParameterDirection.Input)
                );
                command.ExecuteNonQuery();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Joueur.IncrScore : " + sqlExcept.Message);
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
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, 20, this.AliasJoueur, ParameterDirection.Input)
                );

                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    Categorie categorie = DBGlobal.Categories.Find(c => c.CodeCategorie == reader.GetString(0));
                    int score = reader.GetInt32(2);
                    resultat.Add(categorie, score);
                }
                reader.Close();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Joueur.GetScores : " + sqlExcept.Message);
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
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, 20, this.AliasJoueur, ParameterDirection.Input)
                );

                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Categorie categorie = DBGlobal.Categories.Find(c => c.CodeCategorie == reader.GetString(0));
                    resultat.Add(categorie);
                }
                reader.Close();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Joueur.GetCategoriesGagnees : " + sqlExcept.Message);
            }

            return resultat;
        }

        /// <summary>
        /// Retourne la catégorie étant la plus faible/forte du joueur
        /// </summary>
        public Categorie GetCategorieForce(bool estFaible = true)
        {
            Categorie resultat = null;

            try
            {
                OracleCommand command = new OracleCommand(estFaible ? "STATISTIQUES.GetCategorieFaible" : "STATISTIQUES.GetCategorieForte" , DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("resultat", OracleDbType.RefCursor, ParameterDirection.ReturnValue),
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, 20, this.AliasJoueur, ParameterDirection.Input)
                );

                OracleDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    resultat = DBGlobal.Categories.Find(c => c.CodeCategorie == reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Joueur.GetCategorieForce : " + sqlExcept.Message);
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
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, 20, this.AliasJoueur, ParameterDirection.Input)
                );
                command.ExecuteNonQuery();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Joueur.Supprimer : " + sqlExcept.Message);
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
                    new OracleParameter("P_aliasJoueur", OracleDbType.Varchar2, 20, this.AliasJoueur, ParameterDirection.Input),
                    new OracleParameter("P_nom", OracleDbType.Varchar2, 40, this.Nom, ParameterDirection.Input),
                    new OracleParameter("P_prenom", OracleDbType.Varchar2, 40, this.Prenom, ParameterDirection.Input)
                );
                command.ExecuteNonQuery();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Joueur.Ajouter : " + sqlExcept.Message);
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
                MessageBox.Show("Joueur.ChargerTous : " + sqlExcept.Message);
            }

            return resultat;
        }
        #endregion
    }
}
