using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forthProyect
{
    public partial class Form1 : Form
    {
        ShadowVictim shv;
        Point b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shv = new ShadowVictim(this);
            this.Controls.Add(shv.getButton());
            b = new Point(Width + 2, Height + 2);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point a = e.Location;
            if ((b.X != a.X) && (b.Y != a.Y))
            {
                shv.mirar(this,a,b);
            }
            b = a;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            shv.crecer(this);
        }
    }
}
