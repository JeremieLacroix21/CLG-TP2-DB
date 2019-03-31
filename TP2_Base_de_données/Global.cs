using CustomControls;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP2_Base_de_données.Objets_BD;

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

        public static List<Categorie> Categories = new List<Categorie>();
        public static List<Joueur> Joueurs = new List<Joueur>();

        public static void OuvrirConnexion(Form callerForm)
        {
            try
            {
                WaitSplash.Show(callerForm, "Connexion à la base de donnée...");
                Connexion.Open();
                Categories = Categorie.ChargerToutes();
                Joueurs = Joueur.ChargerTous();
                WaitSplash.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>Extension pour surcharger la méthode <see cref="OracleParameterCollection.AddRange(Array)"/> afin de simplifier le code lors de l'ajout de paramètres à un <see cref="OracleCommand.Parameters"/></summary>
        public static void AddRange(this OracleParameterCollection collection, params OracleParameter[] range)
        {
            collection.AddRange(range);
        }

        /// <summary>
        /// Ajoute les éléments de la collection spécifiée à la fin de <see cref="List{T}"/>
        /// <para/>
        /// Extension pour surcharger la méthode <see cref="List{T}.AddRange(T)"/> afin de simplifier le code
        /// </summary>
        /// <param name="collection">
        /// Collection dont les éléments devraient être ajoutés à la fin de <see cref="List{T}"/>
        /// La collection elle-même ne peut pas avoir la valeur null, mais elle peut contenir des éléments qui
        /// sont null, si le type T est un type référence.
        /// </param>
        /// <exception cref="ArgumentNullException">collection a la valeur null.</exception>
        public static void AddRange<T>(this List<T> collection, params T[] range)
        {
            collection.AddRange(range);
        }
    }
}
