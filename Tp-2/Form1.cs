using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int nbTours = 0;

        int nbBateaux = 3;
        int taillePlateaux = 8;

        Plateau joueur;
        Plateau ordinateur;

        private void Form1_Load(object sender, EventArgs e)
        {
            NouvellePartie();
        }

        private void picboxJoueur_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(joueur.Dessiner(), 0, 0);
        }

        private void picboxOrdinateur_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ordinateur.Dessiner(), 0, 0);
        }

        private void picboxJoueur_MouseUp(object sender, MouseEventArgs e)
        {
            joueur.Tirer(e.X,e.Y);
            if (!joueur.ToutBateauxTouche())
            {
                ordinateur.TirerOrdi();
            }
            picboxJoueur.Invalidate();
            picboxOrdinateur.Invalidate();

            LibererRAM(false); // GC.Collect

            if (ordinateur.ToutBateauxTouche() && !joueur.ToutBateauxTouche())
            {
                if (MessageBox.Show("Vous avez perdu\n\nNouvelle partie?", "GAME OVER", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NouvellePartie();
                }
            }
            else if (!ordinateur.ToutBateauxTouche() && joueur.ToutBateauxTouche())
            {
                if (MessageBox.Show("Vous avez gagné\n\nNouvelle partie?", "VICTOIRE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NouvellePartie();
                }
            }
        }

        private void nouvelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NouvellePartie();
        }


        private void dificultéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDifficulte formDifficulte = new FormDifficulte();
            formDifficulte.TransfertInfosEvent += TransfertInfosEvent;
            formDifficulte.Difficulte = taillePlateaux;
            formDifficulte.NbBateaux = nbBateaux;
            formDifficulte.ShowDialog();
        }

        void TransfertInfosEvent(int difficulte_, int nbBateaux_)
        {
            taillePlateaux = difficulte_;
            nbBateaux = nbBateaux_;
            NouvellePartie();
        }


        private void NouvellePartie()
        {
            // plateau sur lequel le joueur joue
            joueur = new Plateau(false, taillePlateaux, picboxJoueur, nbBateaux);
            // plateau sur lequel l'ordinateur joue
            ordinateur = new Plateau(true, taillePlateaux, picboxOrdinateur, nbBateaux);

            joueur.RemplirPlateau();
            ordinateur.RemplirPlateau();
            picboxJoueur.Invalidate();
            picboxOrdinateur.Invalidate();

            LibererRAM(true); // GC.Collect
        }


        private void LibererRAM(bool uneFois)
        {
            if (uneFois) // utiliser une fois
            {
                GC.Collect();
            }
            else // utiliser une fois au 6 tours ( utilisation CPU moindre )
            {
                nbTours++;
                if (nbTours > 5)
                {
                    nbTours = 0;
                    GC.Collect();
                }
            }
        }
    }
}
