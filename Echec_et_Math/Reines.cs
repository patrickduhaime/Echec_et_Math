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
        private int largeur, maxsol;
        private File file;//pour ranger le solutions

        private int nbIttr, nbIttrTotal, trouves;//compteurs

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

        public int getIttrTotal()
        {
            return nbIttrTotal;
        }

        public void reset()
        {
            trouves = 0;

            nbIttr = nbIttrTotal = 0;

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

        public int getNbSolutions()
        {
            return trouves;
        }

        public bool branche(int k)
        {
            if (k == largeur)
            {
                trouves++;
                file.enfiler(new Item("" + trouves, nbIttr, echiquier));
                nbIttrTotal += nbIttr;
                nbIttr = 0;
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

                    //on augmente la profondeur
                    //si on a trouvé une solution et on en a suffisamment
                    if (branche(k + 1) && trouves >= maxsol)
                        return true;

                    //sinon
                    //on libère la case pour la prochaine itération
                    echiquier[k] = -1;
                    diagDroiteGauche[k + j] = 0;
                    diagGaucheDroite[k - j + largeur - 1] = 0;
                }
            }
            //si on a pas trouvé de solution on remonte d'un degré
            return false;
        }

        public bool colonnelibre(int colonne)
        {
            for (int i = 0; i < largeur; i++)
                if (echiquier[i] == colonne)
                    return false;
            return true;
        }

        //diagonale de haut droite à bas gauche
        public bool diagDGlibre(int ligne, int colonne)
        {
            int pos = ligne + colonne;

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

                      if (diagGaucheDroite[pos] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
