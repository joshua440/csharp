using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thirdproyect
{
    public partial class Form1 : Form
    {
        Boolean gafas;
        int texto,genero;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Point p = new Point();
            p.X = rnd.Next(this.Height - button1.Height);
            p.Y = rnd.Next(this.Width - button1.Width);
            button1.Location = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Win");
            timer1.Enabled = false;
            this.Close();
        }
    }
}
