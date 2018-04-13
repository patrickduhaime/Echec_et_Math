using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec_et_Math
{
    class Item
    {
        public string Nom;
        public int[] Solution;

        public Item(string nom, int[] solution)
        {
            Nom = nom; Solution = solution;
        }

        public override string ToString()
        {
            // Generates the text shown in the combo box
            return Nom;
        }
    }
}
