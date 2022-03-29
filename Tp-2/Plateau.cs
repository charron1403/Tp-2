using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tp_2
{
    class Plateau
    {
        Random random = new Random();
        bool visible;
        int taillePlateau;
        int taille;
        int tailleCases;
        int nbBateaux;
        Case[,] tableauCases;

        public Plateau(bool visible_, int taille_, PictureBox picbox, int nbBateaux_)
        {
            visible = visible_;
            taille = taille_;

            taillePlateau = picbox.Width;
            tailleCases = taillePlateau / taille;

            nbBateaux = nbBateaux_;

            TableauCases = new Case[taille,taille];
        }

        internal Case[,] TableauCases { get => tableauCases; set => tableauCases = value; }

        public void RemplirPlateau()
        {
            for (int indexX = 0; indexX <= TableauCases.GetUpperBound(0); indexX++)
            {
                for (int indexY = 0; indexY <= TableauCases.GetUpperBound(1); indexY++)
                {
                    TableauCases[indexX, indexY] = new Case();
                }
            }
            AssignerPositionBateaux(nbBateaux);
        }

        private void AssignerPositionBateaux(int nbBateaux_)
        {
            int randomX = random.Next(0, taille);
            int randomY = random.Next(0, taille);

            for (int nbBateauxAPlace = 0; nbBateauxAPlace < nbBateaux_; nbBateauxAPlace++)
            {
                while (PositionOccupee(randomX, randomY))
                {
                    randomX = random.Next(0, taille);
                    randomY = random.Next(0, taille);
                }
                tableauCases[randomX, randomY].Bateau = true;
            }
        }

        private bool PositionOccupee(int randomX, int RandomY)
        {
            return tableauCases[randomX, RandomY].Bateau;
        }


        public Bitmap Dessiner()
        {
            Bitmap img = new Bitmap(taillePlateau, taillePlateau);

            using (Graphics graphics = Graphics.FromImage(img))
            {
                for (int indexX = 0; indexX <= TableauCases.GetUpperBound(0); indexX++)
                {
                    for (int indexY = 0; indexY <= TableauCases.GetUpperBound(1); indexY++)
                    {
                        graphics.DrawImage(TableauCases[indexX, indexY].Dessiner(tailleCases, visible), tailleCases * indexX, tailleCases * indexY);
                    }
                }
            }

            return img;
        }


        public bool ToutBateauxTouche()
        {
            int nbTouche = 0;
            for (int indexX = 0; indexX <= TableauCases.GetUpperBound(0); indexX++)
            {
                for (int indexY = 0; indexY <= TableauCases.GetUpperBound(1); indexY++)
                {
                    if (TableauCases[indexX, indexY].Bateau && TableauCases[indexX, indexY].Touche)
                    {
                        nbTouche++;
                    }
                }
            }

            if (nbTouche == nbBateaux)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Tirer(int positionX, int positionY)
        {
            int positionXListe = positionX / tailleCases;
            int positionYListe = positionY / tailleCases;

            if (positionXListe > taille - 1)
            {
                positionXListe = taille - 1;
            }
            if (positionXListe < 0)
            {
                positionXListe = 0;
            }
            if (positionYListe > taille - 1)
            {
                positionYListe = taille - 1;
            }
            if (positionYListe < 0)
            {
                positionYListe = 0;
            }

            tableauCases[positionXListe, positionYListe].Touche = true;
        }

        public void TirerOrdi()
        {
            tableauCases[random.Next(0, taille), random.Next(0, taille)].Touche = true;
        }
    }
}
