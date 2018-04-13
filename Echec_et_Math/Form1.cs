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
        private int nbSolutions = 1, premierAffichage = 0;
        int M_size, step;
        JeuEchec jeu;
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
                M_size = Int32.Parse(txtChessBoardSize.Text);
                jeu = new JeuEchec(M_size);
                step = 400 / M_size;

                if (!jeu.chessBoardSolver(0))
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
                else
                {
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
            if (!IsNull(lastItem))
            {
                using (Graphics g = this.CreateGraphics())
                {
                    using (SolidBrush whiteBrush = new SolidBrush(Color.White))
                    using (SolidBrush blackBrush = new SolidBrush(Color.Black))

                        for (int i = 0; i < lastItem.Solution.Length; i++)
                        {
                            int j = lastItem.Solution[i];
                            if (i % 2 == 0)
                            {
                                if(j % 2 == 0)
                                {
                                    g.FillRectangle(blackBrush, i * step, j * step, step, step);
                                }
                                else
                                {
                                    g.FillRectangle(whiteBrush, i * step, j * step, step, step);
                                }
                            }
                            else
                            {
                                if (j % 2 == 0)
                                {
                                    g.FillRectangle(whiteBrush, i * step, j * step, step, step);
                                }
                                else
                                {
                                    g.FillRectangle(blackBrush, i * step, j * step, step, step);
                                }
                            }
                        }
                }
            }

            Item itm = (Item)comboBoxSolutions.SelectedItem;
            
            using (Graphics g = this.CreateGraphics())
            {
                using (SolidBrush redBrush = new SolidBrush(Color.Red))

                for (int i = 0; i < itm.Solution.Length; i++)
                {
                    int j = itm.Solution[i];
                    g.FillRectangle(redBrush, i * step, j * step, step, step);
                }
            }

            lastItem = itm;
        }

        public void addSolution2comboBoxSolutions(int[] solution)
        {
            comboBoxSolutions.Items.Add(new Item("solution " + nbSolutions,  solution));
            nbSolutions++;
            if (premierAffichage == 0)
            {
                comboBoxSolutions.SelectedIndex = 0;
                premierAffichage++;
            }
        }
    }
}

