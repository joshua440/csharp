using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniPracticaFichero
{
    public partial class Form1 : Form
    {
        String[] raza = {"a", "b","c"};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            raceComboBox.Items.AddRange(raza);
            v2comboBox.Items.AddRange(raza);
            v3comboBox.Items.AddRange(raza);
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobComboBox.Items.Clear();
            String aux="", rute= "..\\..\\Resources\\"+raceComboBox.Text+".txt";
            using (StreamReader reader = new StreamReader(rute))
            {
                while ((aux = reader.ReadLine()) != null)
                {
                    jobComboBox.Items.Add(aux);
                }
            }           
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String aux = "", rute = "..\\..\\Resources\\race.txt";
            int i;
            bool auxOut = true;

            v2outcomboBox.Items.Clear();
            using (StreamReader reader = new StreamReader(rute))
            {
                while ((aux = reader.ReadLine()) != null && auxOut)
                {
                    if (String.Equals(v2comboBox.Text, aux.Split('|')[0]))
                    {
                        for(i=1; i<aux.Split('|').Length-1;i++)
                        {
                            v2outcomboBox.Items.Add(aux.Split('|')[i]);
                        }
                        auxOut = false;
                    }
                }
            }
        }

        private void v3comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String aux = "", rute = "..\\..\\Resources\\races.txt";
            String[] auxString = aux.Split(new String[] { "@|*" }, StringSplitOptions.None);
            int i;
            bool auxOut = true;

            v3outcomboBox.Items.Clear();
            using (StreamReader reader = new StreamReader(rute))
            {
                while ((aux = reader.ReadLine()) != null && auxOut)
                {
                    if (String.Equals( v3comboBox.Text, auxString[0] ))
                    {
                        for (i = 0; i < auxString[1].Split('|').Length ; i++)
                        {
                            v3outcomboBox.Items.Add( auxString[1].Split('|')[i] );
                        }
                        auxOut = false;
                    }
                }
            }
        }
    }
}
