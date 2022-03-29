using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tp_2
{
    class Case
    {
        bool bateau;
        bool touche;
        Bitmap case_;

        public bool Bateau { get => bateau; set => bateau = value; }
        public bool Touche { get => touche; set => touche = value; }

        public Case()
        {

        }

        public Bitmap Dessiner(int tailleCase, bool visible)
        {
            Bitmap img = new Bitmap(tailleCase, tailleCase);
            using (Graphics graphics = Graphics.FromImage(img))
            {
                Rectangle contour = new Rectangle(0, 0, tailleCase, tailleCase);
                Rectangle fond = new Rectangle(1, 1, tailleCase - 1, tailleCase - 1);

                Brush brushContour = new SolidBrush(Color.Black);
                graphics.FillRectangle(brushContour, contour);
                Brush brushFond;

                if (touche)
                {
                    if (bateau)
                    {
                        brushFond = new SolidBrush(Color.Gray);
                    }
                    else
                    {
                        brushFond = new SolidBrush(Color.Blue);
                    }
                    graphics.FillRectangle(brushFond, fond);

                    Rectangle point = new Rectangle(tailleCase / 4, tailleCase / 4, tailleCase / 2, tailleCase / 2);
                    Brush brushPoint = new SolidBrush(Color.Red);
                    graphics.FillEllipse(brushPoint, point);
                }
                else
                {
                    if (visible && bateau)
                    {
                        brushFond = new SolidBrush(Color.Gray);
                    }
                    else
                    {
                        brushFond = new SolidBrush(Color.Blue);
                    }
                    graphics.FillRectangle(brushFond, fond);
                }
            }

            return img;
        }
    }
}
