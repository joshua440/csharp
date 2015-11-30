using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("hola");
            String[] a = { "h", "i" };
            comboBox2.Items.AddRange(a);
            comboBox2.SelectedItem = "blanco";
            comboBox2.GetItemText(1);

            String[] b = {"a","b","c","d" };
            comboBox3.Items.AddRange(b);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            String[] c = { "","","",""};
            int i = 0;
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    for (i=0;i<4;i++)
                    {
                        c[i] ="a"+i;
                    }
                    break;
                case 1:
                    for (i = 0; i < 4; i++)
                    {
                        c[i] = "b" + i;
                    }
                    break;
                case 2:
                    for (i = 0; i < 4; i++)
                    {
                        c[i] = "c" + i;
                    }
                    break;
                case 3:
                    for (i = 0; i < 4; i++)
                    {
                        c[i] = "d" + i;
                    }
                    break;
            }
            comboBox4.Items.AddRange(c);
            comboBox4.SelectedIndex=0;
        }
    }
}
