using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echec_et_Math
{
    public partial class Form1 : Form
    {
        private int nbSolutions = 1;
        int M_size, step;
        Reines jeu;
        public static Form1 UI;
        Item lastItem = null;

        public Form1()
        {
            InitializeComponent();
            UI = this;
        }

        private void buttonChessBoardGen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtChessBoardSize.Text))
            {
                MessageBox.Show("Vous devez entrer une dimension avant de generer un echiquier", "Message d'avertissement !",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                comboBoxSolutions.Items.Clear();
                nbSolutions = 1;
                M_size = Int32.Parse(txtChessBoardSize.Text);

                if (checkBox1.Checked)
                    jeu = new Reines(M_size); //à partir de 30 le temps d'exécution explose pour une solution
                                              //à partir de 20/21 pour 10000 solutions
                                              //peut varier selon la machine
                else
                    jeu = new Reines(M_size, 34465);//max 34465 solutions (le combobox se rend pas plus loin :)
                                                    //(à partir de 13 on arrête avant la fin..) 
                step = 400 / M_size; //taille des cases

                //si il n'y a pas de solution
                if (!jeu.branche(0) && !jeu.hasSolutions())
                {
                    using (Graphics g = this.CreateGraphics())
                    {
                        g.Clear(SystemColors.Control); //Clear the draw area
                    }
                    txtChessBoardSize.Text = "";
                    MessageBox.Show("Aucune solution n'a ete trouve pour cet echiquier", "Message d'avertissement !",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else //une ou plusieurs solutions
                {   //remplir le combobox
                    addSolution2comboBoxSolutions();
                    using (Graphics g = this.CreateGraphics())
                    {
                        g.Clear(SystemColors.Control); //Clear the draw area

                        using (SolidBrush blackBrush = new SolidBrush(Color.Black))
                        using (SolidBrush whiteBrush = new SolidBrush(Color.White))
                        {
                            for (int i = 0; i < M_size; i++)
                            {
                                for (int j = 0; j < M_size; j++)
                                {
                                    if ((j % 2 == 0 && i % 2 == 0) || (j % 2 != 0 && i % 2 != 0))
                                        g.FillRectangle(blackBrush, i * step, j * step, step, step);
                                    else if ((j % 2 == 0 && i % 2 != 0) || (j % 2 != 0 && i % 2 == 0))
                                        g.FillRectangle(whiteBrush, i * step, j * step, step, step);
                                }
                            }
                        }
                    }
                }
            }
        }


        public Boolean IsNull(object T)
        {
            return T == null;
        }

        private void comboBoxSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficherSolution();
        }

        private void afficherSolution()
        {
            Item itm = (Item)comboBoxSolutions.SelectedItem;
            labelNTuplesCourant.Text = itm.getntuples().ToString();
            labelNTuples.Text = jeu.getIttrTotal().ToString();
            labelSolTrouvees.Text = jeu.getNbSolutions().ToString();

            if (!IsNull(lastItem))
            {
                using (Graphics g = this.CreateGraphics())
                {
                    using (SolidBrush whiteBrush = new SolidBrush(Color.White))
                    using (SolidBrush blackBrush = new SolidBrush(Color.Black))

                        for (int i = 0; i < lastItem.getLength(); i++)
                        {
                            int j = lastItem.getItem(i);
                            if (i % 2 == 0 && i < itm.getLength())
                            {
                                if (j % 2 == 0 && j < itm.getSolution().Length)
                                {
                                    g.FillRectangle(blackBrush, i * step, j * step, step, step);
                                }
                                else if (j % 2 == 1 && j < itm.getLength())
                                {
                                    g.FillRectangle(whiteBrush, i * step, j * step, step, step);
                                }
                            }
                            else
                            {
                                if (j % 2 == 0 && j < itm.getLength())
                                {
                                    g.FillRectangle(whiteBrush, i * step, j * step, step, step);
                                }
                                else if (j % 2 == 1 && j < itm.getLength())
                                {
                                    g.FillRectangle(blackBrush, i * step, j * step, step, step);
                                }
                            }
                        }
                }
            }

            using (Graphics g = this.CreateGraphics())
            {
                using (SolidBrush redBrush = new SolidBrush(Color.Red))

                    for (int i = 0; i < itm.getLength(); i++)
                    {
                        int j = itm.getItem(i);
                        g.FillRectangle(redBrush, i * step, j * step, step, step);
                    }
            }

            lastItem = itm;
        }


        public void addSolution2comboBoxSolutions()
        {
            while (jeu.hasSolutions())
                comboBoxSolutions.Items.Add(jeu.getNextSolution());
        }
    }
}

