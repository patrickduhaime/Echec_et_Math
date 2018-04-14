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
            Nom = nom;
            Solution = new int[solution.Length];
            solution.CopyTo(Solution, 0);
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
