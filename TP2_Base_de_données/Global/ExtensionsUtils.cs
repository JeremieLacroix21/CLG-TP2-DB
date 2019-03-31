using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Global
{
    public static class ExtensionsUtils
    {
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

        /// <summary>Ajoute un tableau d’objets de contrôle à la collection.</summary>
        public static void AddRange(this ControlCollection collection, params Control[] range)
        {
            collection.AddRange(range);
        }

        /// <summary>
        /// Selects the next item of the list. Selects the first item if the next index is out of bound
        /// </summary>
        public static void SelectNextItem(this ListBox listBox)
        {
            if (listBox.Items.Count > 0)
            {
                if (listBox.SelectedIndex == listBox.Items.Count - 1 || listBox.SelectedItem == null)
                    listBox.SelectedIndex = 0;
                else
                    ++listBox.SelectedIndex;
            }
        }
    }
}
