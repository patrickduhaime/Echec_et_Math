using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec_et_Math
{
    class Noeud
    {
        private Item item;
        private Noeud suivant;

        public Noeud(Item item)
        {
            this.item = item;
            suivant = null;
        }

        public void setItem(Item item)
        {
            this.item = item;
        }

        public Item getItem()
        {
            return this.item;
        }

        public void setSuivant(Noeud suivant)
        {
            this.suivant = suivant;
        }

        public Noeud getSuivant()
        {
            return this.suivant;
        }
    }
}
