using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Objets_BD;
using Custom_Controls;
using System.Drawing;

namespace Global
{
    /// <summary>
    /// Regroupe les constantes, objets ADO.NET et utilitaires utilisés à travers tout le projet qui n'appartiennent pas nécessairement à une classe spécifique
    /// </summary>
    public static class DBGlobal
    {
        #region Elements Connexion

        public const string DB_CLG_USERID = "cloutier";
        public const string DB_CLG_PASSWORD = "123Admin";
        /// <summary>ConnectionString pour la base de donnée mercure.clg.qc.ca</summary>
        public const string CONN_STR_CLG =
            "Data Source = (DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
            + "(HOST=mercure.clg.qc.ca)(PORT=1521)))"
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)));"
            + "User Id = {0}; Password = {1}";

        public static readonly OracleConnection Connexion = new OracleConnection(string.Format(CONN_STR_CLG, DB_CLG_USERID, DB_CLG_PASSWORD));

        #endregion

        public static readonly Categorie CHOISIR = new Categorie() { Couleur = Color.White, Nom = "Choisir" };
        public static int MAX_POINTS_TOTAL { get; private set; }

        public static List<Categorie> Categories { get; private set; }
        public static List<Joueur> Joueurs { get; private set; }

        public static void OuvrirConnexion(Form callerForm)
        {
            try
            {
                WaitSplash.Show(callerForm, "Connexion à la base de donnée...");
                Connexion.Open();
                Categories = Categorie.ChargerToutes();
                MAX_POINTS_TOTAL = Categories.Count * Categorie.GAGNER_NBPOINTS;
                Joueurs = Joueur.ChargerTous();
                InitPointage();
                WaitSplash.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private static void InitPointage()
        {
            foreach (var categorie in Categories)
            {
                foreach (var joueur in Joueurs)
                {
                    joueur.AjouterPointage(categorie, 0);
                }
            }
        }
    }
}
