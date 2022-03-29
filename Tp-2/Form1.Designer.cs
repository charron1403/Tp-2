
namespace Tp_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.picboxJoueur = new System.Windows.Forms.PictureBox();
            this.picboxOrdinateur = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.partieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificultéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picboxJoueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOrdinateur)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxJoueur
            // 
            this.picboxJoueur.Location = new System.Drawing.Point(12, 45);
            this.picboxJoueur.Name = "picboxJoueur";
            this.picboxJoueur.Size = new System.Drawing.Size(320, 320);
            this.picboxJoueur.TabIndex = 0;
            this.picboxJoueur.TabStop = false;
            this.picboxJoueur.Paint += new System.Windows.Forms.PaintEventHandler(this.picboxJoueur_Paint);
            this.picboxJoueur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picboxJoueur_MouseUp);
            // 
            // picboxOrdinateur
            // 
            this.picboxOrdinateur.Location = new System.Drawing.Point(11, 395);
            this.picboxOrdinateur.Name = "picboxOrdinateur";
            this.picboxOrdinateur.Size = new System.Drawing.Size(320, 320);
            this.picboxOrdinateur.TabIndex = 1;
            this.picboxOrdinateur.TabStop = false;
            this.picboxOrdinateur.Paint += new System.Windows.Forms.PaintEventHandler(this.picboxOrdinateur_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vos tirs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Les tirs adverses";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // partieToolStripMenuItem
            // 
            this.partieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleToolStripMenuItem,
            this.dificultéToolStripMenuItem});
            this.partieToolStripMenuItem.Name = "partieToolStripMenuItem";
            this.partieToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.partieToolStripMenuItem.Text = "Partie";
            // 
            // nouvelleToolStripMenuItem
            // 
            this.nouvelleToolStripMenuItem.Name = "nouvelleToolStripMenuItem";
            this.nouvelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouvelleToolStripMenuItem.Text = "Nouvelle";
            this.nouvelleToolStripMenuItem.Click += new System.EventHandler(this.nouvelleToolStripMenuItem_Click);
            // 
            // dificultéToolStripMenuItem
            // 
            this.dificultéToolStripMenuItem.Name = "dificultéToolStripMenuItem";
            this.dificultéToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dificultéToolStripMenuItem.Text = "Difficulté";
            this.dificultéToolStripMenuItem.Click += new System.EventHandler(this.dificultéToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(343, 727);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxOrdinateur);
            this.Controls.Add(this.picboxJoueur);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BattleShip";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxJoueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOrdinateur)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxJoueur;
        private System.Windows.Forms.PictureBox picboxOrdinateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem partieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificultéToolStripMenuItem;
    }
}

