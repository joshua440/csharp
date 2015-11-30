using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hojadepersonaje
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer axWindowsMediaPlayer1 = new WMPLib.WindowsMediaPlayer();
        private const int baseStat = 10, baseHealth=80, baseMana=40, baseEnergy=60, stamina=100;

        public Form1()
        {
            InitializeComponent();
        }

        public void InitializaComponents()
        {
            axWindowsMediaPlayer1.URL= @"C:\Users\joshu\Documents\Visual Studio 2015\Projects\hojadepersonaje\try.mp3";
            axWindowsMediaPlayer1.controls.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                trackBar16.Enabled = true;
            }
            else
            {
                trackBar16.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                trackBar15.Enabled = true;
            }
            else
            {
                trackBar15.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                trackBar14.Enabled = true;
            }
            else
            {
                trackBar14.Enabled = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                trackBar13.Enabled = true;
            }
            else
            {
                trackBar13.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar1.Enabled = true;
            }
            else
            {
                trackBar1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar2.Enabled = true;
            }
            else
            {
                trackBar2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar3.Enabled = true;
            }
            else
            {
                trackBar3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar4.Enabled = true;
            }
            else
            {
                trackBar4.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar5.Enabled = true;
            }
            else
            {
                trackBar5.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar6.Enabled = true;
            }
            else
            {
                trackBar6.Enabled = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar12.Enabled = true;
            }
            else
            {
                trackBar12.Enabled = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar11.Enabled = true;
            }
            else
            {
                trackBar11.Enabled = false;
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            axWindowsMediaPlayer1.controls.play();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar10.Enabled = true;
            }
            else
            {
                trackBar10.Enabled = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar9.Enabled = true;
            }
            else
            {
                trackBar9.Enabled = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar8.Enabled = true;
            }
            else
            {
                trackBar8.Enabled = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                trackBar7.Enabled = true;
            }
            else
            {
                trackBar7.Enabled = false;
            }
        }
    }
}
