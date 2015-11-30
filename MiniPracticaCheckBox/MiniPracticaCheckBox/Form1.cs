using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPracticaCheckBox
{
    public partial class Form1 : Form
    {
        private CheckBox[] ch1 = new CheckBox[1], ch2 = new CheckBox[2], ch2all = new CheckBox[2];
        Boolean b1 = true, b2 = true;
        Random rnd = new Random();
        int cuenta =0;
        DateTime cont;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ch2all[0] = checkBox9;
            ch2all[0].Checked = true;
            ch2all[1] =checkBox11;
            ch2all[1].Checked = true;
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ch1[0] == null)
            {
                ch1[0] = checkBox1;
                checkBox1.Checked = true;
            } else
            {
                ch1[0].Checked = false;
                ch1[0] = checkBox1;
                checkBox1.Checked = true;
            }
        }

        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (ch1[0] == null)
            {
                ch1[0] = checkBox2;
                checkBox2.Checked = true;
            }
            else
            {
                ch1[0].Checked = false;
                ch1[0] = checkBox2;
                checkBox2.Checked = true;
            }
        }

        private void checkBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (ch1[0] == null)
            {
                ch1[0] = checkBox3;
                checkBox3.Checked = true;
            }
            else
            {
                ch1[0].Checked = false;
                ch1[0] = checkBox3;
                checkBox3.Checked = true;
            }
        }

        private void checkBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox5.Checked)
            {
                if (ch2[0] == null)
                {
                    ch2[0] = checkBox5;
                    checkBox5.Checked = true;
                }
                else if (ch2[1] == null)
                {
                    ch2[1] = checkBox5;
                    checkBox5.Checked = true;
                }
                else
                {
                    if (b1)
                    {
                        ch2[0].Checked = false;
                        ch2[0] = checkBox5;
                        checkBox5.Checked = true;
                    }
                    else
                    {
                        ch2[1].Checked = false;
                        ch2[1] = checkBox5;
                        checkBox5.Checked = true;
                    }
                }
            }
            b1 = !b1;
        }

        private void checkBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox6.Checked)
            {
                if (ch2[0] == null)
                {
                    ch2[0] = checkBox6;
                    checkBox6.Checked = true;
                }
                else if (ch2[1] == null)
                {
                    ch2[1] = checkBox6;
                    checkBox6.Checked = true;
                }
                else
                {
                    if (b1)
                    {
                        ch2[0].Checked = false;
                        ch2[0] = checkBox6;
                        checkBox6.Checked = true;
                    }
                    else
                    {
                        ch2[1].Checked = false;
                        ch2[1] = checkBox6;
                        checkBox6.Checked = true;
                    }
                }
            }
            b1 = !b1;
        }

        private void checkBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox7.Checked)
            {
                if (ch2[0] == null)
                {
                    ch2[0] = checkBox7;
                    checkBox7.Checked = true;
                }
                else if (ch2[1] == null)
                {
                    ch2[1] = checkBox7;
                    checkBox7.Checked = true;
                }
                else
                {
                    if (b1)
                    {
                        ch2[0].Checked = false;
                        ch2[0] = checkBox7;
                        checkBox7.Checked = true;
                    }
                    else
                    {
                        ch2[1].Checked = false;
                        ch2[1] = checkBox7;
                        checkBox7.Checked = true;
                    }
                }
            }
            b1 = !b1;
        }

        private void checkBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox8.Checked)
            {
                if (ch2[0] == null)
                {
                    ch2[0] = checkBox8;
                    checkBox8.Checked = true;
                }
                else if (ch2[1] == null)
                {
                    ch2[1] = checkBox8;
                    checkBox8.Checked = true;
                }
                else
                {
                    if (b1)
                    {
                        ch2[0].Checked = false;
                        ch2[0] = checkBox8;
                        checkBox8.Checked = true;
                    }
                    else
                    {
                        ch2[1].Checked = false;
                        ch2[1] = checkBox8;
                        checkBox8.Checked = true;
                    }
                }
            }
            b1 = !b1;
        }
        
        private void checkBox9_MouseClick(object sender, MouseEventArgs e)
        {
            if (b2)
            {
                ch2all[0].Checked = false;
                ch2all[0] = checkBox9;
                checkBox9.Checked = true;
            }
            else
            {
                ch2all[1].Checked = false;
                ch2all[1] = checkBox9;
                checkBox9.Checked = true;
            }
            b2 = !b2;
        }

        private void checkBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (ch1[0] == null)
            {
                ch1[0] = checkBox4;
                checkBox4.Checked = true;
            }
            else
            {
                ch1[0].Checked = false;
                ch1[0] = checkBox4;
                checkBox4.Checked = true;
            }
        }

        private void checkBox10_MouseClick(object sender, MouseEventArgs e)
        {
            if (b2)
            {
                ch2all[0].Checked = false;
                ch2all[0] = checkBox10;
                checkBox10.Checked = true;
            }
            else
            {
                ch2all[1].Checked = false;
                ch2all[1] = checkBox10;
                checkBox10.Checked = true;
            }
            b2 = !b2;
        }

        private void checkBox11_MouseClick(object sender, MouseEventArgs e)
        {
            if (b2)
            {
                ch2all[0].Checked = false;
                ch2all[0] = checkBox11;
                checkBox11.Checked = true;
            }
            else
            {
                ch2all[1].Checked = false;
                ch2all[1] = checkBox11;
                checkBox11.Checked = true;
            }
            b2 = !b2;
        }

        private void checkBox12_MouseClick(object sender, MouseEventArgs e)
        {
            if (b2)
            {
                ch2all[0].Checked = false;
                ch2all[0] = checkBox12;
                checkBox12.Checked = true;
            }
            else
            {
                ch2all[1].Checked = false;
                ch2all[1] = checkBox12;
                checkBox12.Checked = true;
            }
            b2 = !b2;
        }

        private void checkBox13_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox16.Checked = true;
            checkBox15.Checked = true;
            checkBox14.Checked = true;
            checkBox13.Checked = true;
        }

        private void checkBox14_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox16.Checked = true;
            checkBox15.Checked = true;
            checkBox14.Checked = true;
            checkBox13.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox15_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox16.Checked = true;
            checkBox15.Checked = true;
            checkBox14.Checked = false;
            checkBox13.Checked = false;
        }

        private void checkBox16_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox16.Checked = true;
            checkBox15.Checked = false;
            checkBox14.Checked = false;
            checkBox13.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cuenta++;
            if (cuenta==1) {
                cont = DateTime.Now;
            }
            CheckBox ch = new CheckBox();
            DateTime dAux = DateTime.Now;
            ch.Text =String.Format("%d %d %d",dAux.Hour,dAux.Minute,dAux.Second);
            ch.Location = new Point(rnd.Next(this.Height),rnd.Next(this.Width));
            this.Controls.Add(ch);
            if (dAux.Second - cont.Second > 10)
            {
                foreach (Object ob in this.Controls)
                {
                    if (ob is CheckBox)
                    {
                        ((CheckBox)ob).Checked = false;
                    }
                }
                cont = DateTime.Now;
            }
        }
        
    }
}
