using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec_et_Math
{
    class Reines
    {
        private int[] echiquier, diagDroiteGauche, diagGaucheDroite;
        private int largeur, maxsol, trouves;
        private File file;//pour ranger le solutions

        private int nbIttr, nbAff, nbComp;//compteurs

        public Reines()
        {
            maxsol = 1;
            setLargeur(8);
        }

        public Reines(int side)
        {
            maxsol = 1;
            setLargeur(side);
        }

        public Reines(int side, int max)
        {
            maxsol = max;
            setLargeur(side);
        }

        public void setLargeur(int side)
        {
            largeur = side;
            reset();
        }

        public int getLargeur()
        {
            return largeur;
        }
        public int getDimension()
        {
            return largeur * largeur;
        }

        public int getIttr()
        {
            return nbIttr;
        }

        public int getAff()
        {
            return nbAff;
        }

        public int getComp()
        {
            return nbComp;
        }

        public void reset()
        {
            trouves = 0;

            nbIttr = nbAff = nbComp = 0;

            echiquier = new int[largeur];
            for (int i = 0; i < largeur; i++)
                echiquier[i] = -1;
            diagDroiteGauche = new int[2 * largeur - 1];
            diagGaucheDroite = new int[2 * largeur - 1];
            file = new File();
        }

        public Item getNextSolution()
        {
            return file.defiler();
        }

        public bool hasSolutions()
        {
            return !file.estVide();
        }

        public bool branche(int k)
        {
            if (k == largeur)
            {
                trouves++;
                file.enfiler(new Item("" + trouves, echiquier));
                return true;//on a trouvé une solution
            }
            for (int j = 0; j < largeur; j++)
            {
                nbIttr++;
                if (colonnelibre(j) && diagDGlibre(k, j) && diagGDlibre(k, j))
                {
                    //on occupe la case
                    echiquier[k] = j;
                    diagDroiteGauche[k + j] = 1;
                    diagGaucheDroite[k - j + largeur - 1] = 1;

                    nbAff = nbAff + 3;
                    //on augmente la profondeur
                    //si on a trouvé une solution et on en a suffisamment
                    if (branche(k + 1) && trouves >= maxsol)
                    {
                        nbComp++;
                        return true;
                    }
                    //sinon
                    //on libère la case pour la prochaine itération
                    echiquier[k] = -1;
                    diagDroiteGauche[k + j] = 0;
                    diagGaucheDroite[k - j + largeur - 1] = 0;

                    nbAff = nbAff + 3;
                }
            }
            //si on a pas trouvé de solution on remonte d'un degré
            return false;
        }

        public bool colonnelibre(int colonne)
        {
            for (int i = 0; i < largeur; i++)
            {
                nbComp++;

                if (echiquier[i] == colonne)
                    return false;
            }
            return true;
        }

        //diagonale de haut droite à bas gauche
        public bool diagDGlibre(int ligne, int colonne)
        {
            int pos = ligne + colonne;

            nbComp++;
            if (diagDroiteGauche[pos] == 0)
            {
                return true;
            }
            return false;
        }

        //diagonale de haut gauche à bas droite
        public bool diagGDlibre(int ligne, int colonne)
        {
            int pos = ligne - colonne + largeur - 1;

            nbComp++;
            if (diagGaucheDroite[pos] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
