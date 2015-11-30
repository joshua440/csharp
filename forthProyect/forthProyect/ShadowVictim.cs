using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forthProyect
{
    class ShadowVictim
    {
        private Victim v;
        private Button btn;
        Random rnd = new Random();
        private Point p;

        public ShadowVictim(Form f)
        {
            v = new Victim(f.Width, f.Height, 50, 250, 5);
            btn = new Button();
            p = new Point((v.getSize() / 2) + rnd.Next(f.Height - (v.getSize() / 2)), ((v.getSize() / 2) + rnd.Next(f.Width - (v.getSize() / 2))));
            btn.Size = v.getSideAux();
            btn.BackgroundImage = v.getI();
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = p;
            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.ForeColor = System.Drawing.Color.Transparent;
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.Text = "";
        }
        public Victim getVictim()
        {
            return v;
        }
        public Button getButton()
        {
            return btn;
        }
        public void morir()
        {
            v = null;
            btn.Dispose();
        }
        public void mirar(Form f,Point a, Point b)
        {
            btn.Location = v.mirar(a, f.Height, f.Width,btn.Location);
        }
        public void crecer(Form f)
        {
            if (v.getSize() < v.getMaxSize())
            {
                getVictim().crecer();
                if (f.Height <= btn.Location.Y + v.getSize()+btn.Height)
                {
                    btn.Location = new System.Drawing.Point(btn.Location.Y - v.getGrowing());
                }
                if (f.Width <= btn.Location.X + v.getSize()+btn.Width)
                {
                    btn.Location = new System.Drawing.Point(btn.Location.X - v.getGrowing());
                }
                getButton().Size = getVictim().getSideAux();
            }
        }
    }
}
