using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressList( object sender) {
            Boolean b1 = true;
            foreach (Object pnl in ((Control)((RadioButton)sender).Parent.Parent).Controls){
                if (pnl is Panel)
                {
                    foreach (Object rd in ((Panel)pnl).Controls) {
                        ((RadioButton)rd).Checked = b1;
                        if (((RadioButton)rd).Equals(((RadioButton)sender)))
                        {
                            b1 = false;
                        }
                    }
                                    
                }
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            progressList(sender);
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            progressList(sender);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            progressList(sender);
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            progressList(sender);
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            progressList(sender);
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            progressList(sender);
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            progressList(sender);
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            progressList(sender);
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            progressList(sender);
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            progressList(sender);
        }
    }
}
