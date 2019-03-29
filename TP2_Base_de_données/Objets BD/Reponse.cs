using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Base_de_données.Objets_BD
{
    public class Reponse
    {
        public string NumReponse { get; set; }
        public string Description { get; set; }
        public bool EstBonne { get; set; }
        public Question Question { get; set; }
    }
}
