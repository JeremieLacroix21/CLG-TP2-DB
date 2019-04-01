﻿using Global;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Objets_BD
{
    public class Reponse
    {
        public string NumReponse { get; set; }
        public string Description { get; set; }
        public bool EstBonne { get; set; }
        public Question Question { get; set; }

        #region Requêtes BD
        /// <summary>
        /// Ajoute la réponse à la base de donnée
        /// </summary>
        /// <exception cref="ArgumentException">Certaines propriétés de la réponse sont null</exception>
        // TODO : InsertReponse() a été changé dans la BD, Ajouter() est à modifier pour prendre en compte ces changements
        [Obsolete("InsertReponse() a été changé dans la BD, Ajouter() est à modifier pour prendre en compte ces changements", true)]
        public void Ajouter()
        {
            // Vérifier que toute les propriétés de la réponse sont valide
            if (this.NumReponse == null || this.Description == null || this.Question == null || this.Question.NumQuestion == null)
            {
                throw new ArgumentException("Certaines propriétés de la réponse sont null");
            }

            try
            {
                OracleCommand command = new OracleCommand("GESTIONQUESTIONS.InsertReponse", DBGlobal.Connexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(
                    new OracleParameter("P_numReponse", OracleDbType.Varchar2, ParameterDirection.Input),
                    new OracleParameter("P_description", OracleDbType.Varchar2, this.Description, ParameterDirection.Input),
                    new OracleParameter("P_estBonne", OracleDbType.Char, (this.EstBonne ? "Y" : "N"), ParameterDirection.Input),
                    new OracleParameter("P_numQuestion", OracleDbType.Varchar2, this.Question.NumQuestion, ParameterDirection.Input)
                );
                command.ExecuteNonQuery();
            }
            catch (Exception sqlExcept)
            {
                MessageBox.Show("Reponse.Ajouter : " + sqlExcept.Message);
            }
        }
        #endregion
    }
}
