using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec_et_Math
{
    class ListeChainee
    {
        private Noeud premier;
        private Noeud dernier;

        public ListeChainee()
        {
            premier = null;
            dernier = null;
        }

        public void insererFin(Item item)
        {
            Noeud noeud = new Noeud(item);

            if (estVide())
                this.premier = noeud;
            else
                this.dernier.setSuivant(noeud);
            this.dernier = noeud;
        }

        public Noeud supprimerDebut()
        {
            if (!estVide())
            {
                Noeud noeud = this.premier;

                if (this.premier.getSuivant() == null)
                    this.dernier = null;

                this.premier = this.premier.getSuivant();
                return noeud;
            }
            return null;
        }

        public bool estVide()
        {
            return this.premier == null;
        }
    }
}
