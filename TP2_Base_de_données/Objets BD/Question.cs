using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Base_de_données.Objets_BD
{
    public class Question
    {
        public string NumQuestion { get; set; }
        public string Enonce { get; set; }
        public bool Repondu { get; set; }
        public Categorie Categorie { get; set; }
        public List<Reponse> Reponses { get; set; }
    }
}
