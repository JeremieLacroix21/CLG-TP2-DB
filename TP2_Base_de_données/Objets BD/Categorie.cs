using Global;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Objets_BD
{
    public class Categorie
    {
        /// <summary>Le nombre de points nécessaires pour gagner une catégorie</summary>
        public const int GAGNER_NBPOINTS = 2;

        public string CodeCategorie { get; set; }
        public string Nom { get; set; }
        public Color Couleur { get; set; }

        public override string ToString()
        {
            return Nom;
        }

        #region Requêtes BD
        /// <summary>
        /// Remet le flag gagnee pour chaque catégorie pour chaque joueur à false
        /// </summary>
        public static void ResetCategoriesGagnee()
        {
            try
            {
                OracleCommand command = new OracleCommand("STATISTIQUES.ResetCategoriesGagnee", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Categorie.ResetCategoriesGagnee : " + sqlExcept.Message);
            }
        }

        /// <summary>
        /// Retourne la totalité des catégories de la base de donnée
        /// </summary>
        public static List<Categorie> ChargerToutes()
        {
            List<Categorie> resultat = new List<Categorie>();

            try
            {
                OracleCommand command = new OracleCommand("GESTIONCATEGORIES.GetToutesCategories", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("resultat", OracleDbType.RefCursor, ParameterDirection.ReturnValue)
                );

                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Categorie categorie = new Categorie()
                    {
                        CodeCategorie = reader.GetString(0),
                        Nom = reader.GetString(1),
                        Couleur = Color.FromName(reader.GetString(2))
                    };
                    resultat.Add(categorie);
                }
                reader.Close();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Categorie.ChargerToutes : " + sqlExcept.Message);
            }

            return resultat;
        }
        #endregion
    }
}
