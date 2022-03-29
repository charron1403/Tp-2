
namespace Tp_2
{
    partial class FormDifficulte
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
            this.comboxDifficulte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.NUDBateaux = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBateaux)).BeginInit();
            this.SuspendLayout();
            // 
            // comboxDifficulte
            // 
            this.comboxDifficulte.BackColor = System.Drawing.Color.Black;
            this.comboxDifficulte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboxDifficulte.ForeColor = System.Drawing.Color.White;
            this.comboxDifficulte.FormattingEnabled = true;
            this.comboxDifficulte.Location = new System.Drawing.Point(26, 34);
            this.comboxDifficulte.Name = "comboxDifficulte";
            this.comboxDifficulte.Size = new System.Drawing.Size(121, 21);
            this.comboxDifficulte.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Niveau de difficulté";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de bateaux";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Location = new System.Drawing.Point(120, 66);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // NUDBateaux
            // 
            this.NUDBateaux.BackColor = System.Drawing.Color.Black;
            this.NUDBateaux.ForeColor = System.Drawing.Color.White;
            this.NUDBateaux.Location = new System.Drawing.Point(169, 34);
            this.NUDBateaux.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NUDBateaux.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDBateaux.Name = "NUDBateaux";
            this.NUDBateaux.Size = new System.Drawing.Size(120, 20);
            this.NUDBateaux.TabIndex = 5;
            this.NUDBateaux.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // FormDifficulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(323, 98);
            this.Controls.Add(this.NUDBateaux);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxDifficulte);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDifficulte";
            this.Text = "Difficulté";
            this.Load += new System.EventHandler(this.FormDifficulte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDBateaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxDifficulte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.NumericUpDown NUDBateaux;
    }
}