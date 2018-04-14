namespace Echec_et_Math
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChessBoardSize = new System.Windows.Forms.TextBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonChessBoardGen = new System.Windows.Forms.Button();
            this.labelChessBoardSize = new System.Windows.Forms.Label();
            this.labelControl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCounter = new System.Windows.Forms.Label();
            this.comboBoxSolutions = new System.Windows.Forms.ComboBox();
            this.labelSolution = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNTuples = new System.Windows.Forms.Label();
            this.labelNTuplesCourant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSolTrouvees = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChessBoardSize
            // 
            this.txtChessBoardSize.Location = new System.Drawing.Point(116, 14);
            this.txtChessBoardSize.Name = "txtChessBoardSize";
            this.txtChessBoardSize.Size = new System.Drawing.Size(48, 20);
            this.txtChessBoardSize.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl.Controls.Add(this.checkBox1);
            this.panelControl.Controls.Add(this.buttonChessBoardGen);
            this.panelControl.Controls.Add(this.labelChessBoardSize);
            this.panelControl.Controls.Add(this.txtChessBoardSize);
            this.panelControl.Location = new System.Drawing.Point(420, 25);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(188, 118);
            this.panelControl.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(27, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Arrêter à la première solution";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonChessBoardGen
            // 
            this.buttonChessBoardGen.Location = new System.Drawing.Point(27, 63);
            this.buttonChessBoardGen.Name = "buttonChessBoardGen";
            this.buttonChessBoardGen.Size = new System.Drawing.Size(137, 23);
            this.buttonChessBoardGen.TabIndex = 2;
            this.buttonChessBoardGen.Text = "Generer";
            this.buttonChessBoardGen.UseVisualStyleBackColor = true;
            this.buttonChessBoardGen.Click += new System.EventHandler(this.buttonChessBoardGen_Click);
            // 
            // labelChessBoardSize
            // 
            this.labelChessBoardSize.AutoSize = true;
            this.labelChessBoardSize.Location = new System.Drawing.Point(24, 17);
            this.labelChessBoardSize.Name = "labelChessBoardSize";
            this.labelChessBoardSize.Size = new System.Drawing.Size(59, 13);
            this.labelChessBoardSize.TabIndex = 1;
            this.labelChessBoardSize.Text = "Dimension:";
            // 
            // labelControl
            // 
            this.labelControl.AutoSize = true;
            this.labelControl.Location = new System.Drawing.Point(417, 9);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(40, 13);
            this.labelControl.TabIndex = 2;
            this.labelControl.Text = "Control";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelSolTrouvees);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelNTuplesCourant);
            this.panel1.Controls.Add(this.labelNTuples);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(420, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 156);
            this.panel1.TabIndex = 3;
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(417, 157);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(44, 13);
            this.labelCounter.TabIndex = 4;
            this.labelCounter.Text = "Counter";
            // 
            // comboBoxSolutions
            // 
            this.comboBoxSolutions.FormattingEnabled = true;
            this.comboBoxSolutions.Location = new System.Drawing.Point(420, 359);
            this.comboBoxSolutions.Name = "comboBoxSolutions";
            this.comboBoxSolutions.Size = new System.Drawing.Size(188, 21);
            this.comboBoxSolutions.TabIndex = 5;
            this.comboBoxSolutions.SelectedIndexChanged += new System.EventHandler(this.comboBoxSolutions_SelectedIndexChanged);
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Location = new System.Drawing.Point(417, 343);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(45, 13);
            this.labelSolution.TabIndex = 6;
            this.labelSolution.Text = "Solution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.MaximumSize = new System.Drawing.Size(180, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "N-Tuples visités pour la solution courante:";
            // 
            // labelNTuples
            // 
            this.labelNTuples.AutoSize = true;
            this.labelNTuples.Location = new System.Drawing.Point(162, 72);
            this.labelNTuples.Name = "labelNTuples";
            this.labelNTuples.Size = new System.Drawing.Size(0, 13);
            this.labelNTuples.TabIndex = 1;
            // 
            // labelNTuplesCourant
            // 
            this.labelNTuplesCourant.AutoSize = true;
            this.labelNTuplesCourant.Location = new System.Drawing.Point(164, 17);
            this.labelNTuplesCourant.Name = "labelNTuplesCourant";
            this.labelNTuplesCourant.Size = new System.Drawing.Size(0, 13);
            this.labelNTuplesCourant.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.MaximumSize = new System.Drawing.Size(180, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "N-Tuples visités pour toutes les solutions :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nb de solutions trouvées:";
            // 
            // labelSolTrouvees
            // 
            this.labelSolTrouvees.AutoSize = true;
            this.labelSolTrouvees.Location = new System.Drawing.Point(165, 113);
            this.labelSolTrouvees.Name = "labelSolTrouvees";
            this.labelSolTrouvees.Size = new System.Drawing.Size(0, 13);
            this.labelSolTrouvees.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.comboBoxSolutions);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.panelControl);
            this.Name = "Form1";
            this.Text = "Echec et Math";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChessBoardSize;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonChessBoardGen;
        private System.Windows.Forms.Label labelChessBoardSize;
        private System.Windows.Forms.Label labelControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.ComboBox comboBoxSolutions;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelNTuples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNTuplesCourant;
        private System.Windows.Forms.Label labelSolTrouvees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

