using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((ProgressBar)sender).Value < ((ProgressBar)sender).Maximum)
            {
                ((ProgressBar)sender).Value++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (((ProgressBar)sender).Value > ((ProgressBar)sender).Minimum)
            {
                ((ProgressBar)sender).Value--;
            }
        }

        private void progressBar2_MouseClick(object sender, MouseEventArgs e)
        {
            if ( e.Location.X < ((ProgressBar)sender).Width / 2 )
            {
                if (((ProgressBar)sender).Value > ((ProgressBar)sender).Minimum)
                {
                    ((ProgressBar)sender).Value--;
                } 
            } else
            {
                if (((ProgressBar)sender).Value < ((ProgressBar)sender).Maximum)
                {
                    ((ProgressBar)sender).Value++;
                }
            }
        }

        private void progressBar3_MouseClick(object sender, MouseEventArgs e)
        {
            double max = ((ProgressBar)sender).Maximum, now= ((ProgressBar)sender).Value, wid=((ProgressBar)sender).Width, prog=(now*wid)/max;
            if (e.Location.X > prog)
            {
                if (((ProgressBar)sender).Value < ((ProgressBar)sender).Maximum)
                {
                    ((ProgressBar)sender).Value++;
                }
            } else
            {
                if (((ProgressBar)sender).Value > ((ProgressBar)sender).Minimum)
                {
                    ((ProgressBar)sender).Value--;
                }
            }
        }

        private void progressBar4_MouseClick(object sender, MouseEventArgs e)
        {
            double max = ((ProgressBar)sender).Maximum, wid = ((ProgressBar)sender).Width, rX= e.Location.X;
            ((ProgressBar)sender).Value = (int)Math.Ceiling((decimal)(rX*max/wid));
        }
    }
}
