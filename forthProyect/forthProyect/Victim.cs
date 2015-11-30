using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forthProyect
{
    class Victim
    {
        private int speed, side, sight, maxSide, growing;
        private Size sideAux;
        private Image i=Properties.Resources.AndroidLogo;
        Random rnd = new Random();
        
        public Victim(int widthForm, int heightForm)
        {
            speed = rnd.Next(10);
            growing = 5;
            side =10;
            maxSide = (widthForm+heightForm) / 6;
            sight = (heightForm+widthForm)/3;
        }
        public Victim(int heightForm, int widthForm, int side, int sight, int speed)
        {
            this.speed = speed;
            growing = 5;
            this.side = side;
            maxSide = (widthForm + heightForm) / 6;
            sideAux = new Size(side,side);
            this.sight = sight;
        }

        public int getGrowing()
        {
            return growing;
        }
        public int getMaxSize()
        {
            return maxSide;
        }
        public int getSize()
        {
            return side;
        }
        public Image getI()
        {
            return i;
        }
        public Size getSideAux()
        {
            return sideAux;
        }
        public void crecer()
        {
            if (side < maxSide)
            {
                side = side + growing;
                sideAux = new Size(side,side);
            }
        }
        public void morir()
        {

        }
        public Point mirar(Point m, int heightForm, int widthForm, Point p)
        {
            if(Math.Pow(Math.Pow(m.X-(p.X+side/2),2) + Math.Pow(m.Y - (p.Y + side/2), 2),0.5)<sight)
            {
                huir(m,heightForm,widthForm,p);
            }
            return p;
        }
        public void huir(Point m, int heightForm, int widthForm, Point p)
        {
            if (p.X < m.X && p.X > 0 + speed)
            {
                p = new Point(p.X - speed, p.Y);
            }
            else if(p.X > m.X && p.X < widthForm - side - speed)
            {
                p = new Point(p.X + speed, p.Y);
            }

            if (p.Y < m.Y && p.Y > 0 + speed)
            {
                p = new Point(p.X, p.Y - speed);
            }
            else if (p.Y > m.Y && p.Y < heightForm - side - speed)
            {
                p = new Point(p.X, p.Y + speed);
            }
        }
    }
}
