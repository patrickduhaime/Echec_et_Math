using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec_et_Math
{
    class File
    {
        private ListeChainee liste;
        private int nbItem;

        public File()
        {
            nbItem = 0;
            liste = new ListeChainee();
        }

        public bool estVide()
        {
            return nbItem == 0;
        }

        public void enfiler(Item item)
        {
            nbItem++;
            liste.insererFin(item);
        }

        public Item defiler()
        {
            if (nbItem > 0)
            {
                nbItem--;
                return liste.supprimerDebut().getItem();
            }
            return null;
        }
    }
}
