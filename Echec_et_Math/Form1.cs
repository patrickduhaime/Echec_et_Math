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
        public Form1()
        {
            InitializeComponent();
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
                int M_size = Int32.Parse(txtChessBoardSize.Text);
                JeuEchec jeu = new JeuEchec(M_size);
                int step = 400 / M_size;

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
                        using (SolidBrush redBrush = new SolidBrush(Color.Red))
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
                                    if (jeu.chessBoard[i, j] == 1)
                                        g.FillRectangle(redBrush, i * step, j * step, step, step);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

