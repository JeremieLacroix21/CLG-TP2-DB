using CustomControls;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static readonly List<Categorie> Categories = new List<Categorie>();

        public static void OuvrirConnexion(Form callerForm)
        {
            try
            {
                WaitSplash.Show(callerForm, "Connexion à la base de donnée...");
                Connexion.Open();
                WaitSplash.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>Extension de la méthode <see cref="OracleParameterCollection.AddRange(Array)"/> pour simplifier le code lors de l'ajout de paramètres à un <see cref="OracleCommand.Parameters"/></summary>
        public static void AddRange(this OracleParameterCollection collection, params OracleParameter[] range)
        {
            collection.AddRange(range);
        }
    }
}
