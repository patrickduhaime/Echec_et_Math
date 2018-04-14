using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec_et_Math
{
    class Item
    {
        private string Nom;
        private int ntuples;
        private int[] Solution;

        public Item(string nom, int ntuples, int[] solution)
        {
            Nom = nom;
            this.ntuples = ntuples;
            Solution = new int[solution.Length];
            solution.CopyTo(Solution, 0);
        }

        public int getntuples()
        {
            return ntuples;
        }

        public int[] getSolution()
        {
            return Solution;
        }

        public int getItem(int indice)
        {
            return Solution[indice];
        }

        public int getLength()
        {
            return Solution.Length;
        }
        public override string ToString()
        {
            return Nom;
        }
    }
}
