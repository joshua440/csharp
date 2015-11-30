using System;
using System.Drawing;
using System.Windows.Forms;

namespace HojaPersonaje2._0
{
    public partial class Form1 : Form
    {
        private WMPLib.WindowsMediaPlayer mp3player= new WMPLib.WindowsMediaPlayer();
        private int auxDef, auxDefM, auxClassDef, auxClassDefM;
        private const int STAT_SIZE=24;
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mp3player.URL = @"C:\Users\joshu\Documents\Visual Studio 2015\Projects\HojaPersonaje2.0\Spiritual_Abyss.mp3";
            mp3player.controls.play();
            mp3player.settings.setMode("loop", true);
            initCreatePj();
        }

        private void initCreatePj()
        {
            raceComboBox.SelectedIndex = 0;
            classComboBox.SelectedIndex = 0;
            auxDef = 0;
            auxDefM = 0;
            auxClassDef = 0;
            auxClassDefM = 0;
            nameTextBox.Text = "";
            nameTextBox.Tag = false;
            generePanel.Tag = false;
            choosedStatsPanel.Tag = false;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            foreach (object ob in choosedStatsPanel.Controls)
            {
                if (ob is NumericUpDown)
                {
                    ((NumericUpDown)ob).Tag = ( ((NumericUpDown)ob).Value = 0 );
                }
            }
            totalStatsProgressBar.Tag = ( totalStatsProgressBar.Value = 100 );
        }

        private void barraStatRaza(int vida, int mana, int ki, int energia,int stamina, int defensa,  int defensaMagica)
        {
            auxDef = defensa;
            auxDefM = defensaMagica;
            progBarColor(progressBar2, vida);
            progBarColor(progressBar3, mana);
            progBarColor(progressBar4, ki);
            progBarColor(progressBar6, energia);
            progBarColor(progressBar7, stamina);
            progBarColor(progressBar8, auxDef + auxClassDef);
            progBarColor(progressBar9, auxDefM + auxClassDefM);
        }

        private void barraStatClase(int iniciativa, int defensa, int defensaMagica)
        {
            auxClassDef = defensa;
            auxClassDefM = defensaMagica;
            progBarColor(progressBar5, iniciativa);
            progBarColor(progressBar8, auxDef + auxClassDef);
            progBarColor(progressBar9, auxDefM + auxClassDefM);
        }

        private void progBarColor(ProgressBar p,int cantidad)
        {
            p.Width = STAT_SIZE * (cantidad);
            switch (cantidad)
            {
                case 1:
                    p.ForeColor = Color.Black;
                    break;
                case 2:
                    p.ForeColor = Color.Red;
                    break;
                case 3:
                    p.ForeColor = Color.Yellow;
                    break;
                case 4:
                    p.ForeColor = Color.LimeGreen;
                    break;
                case 5:
                    p.ForeColor = Color.Purple;
                    break;
            }
        }
        
        private void secondPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Visible)
            {
                nextButton.Enabled = false;
                nextButton.Visible = false;
            }
            else
            {
                nextButton.Enabled = true;
                nextButton.Visible = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] cmb3 = null, cmb4 = null;

            skinComboBox.Items.Clear();
            hairComboBox.Items.Clear();

            switch (raceComboBox.SelectedIndex)
            {
                case 0://Aurtip
                    barraStatRaza(3, 2, 4, 4, 3, 2, 1);
                    ageTextBox.Text = "100";
                    break;
                case 1://Borghel
                    cmb3 = new String[2];
                    cmb3[0] = "Naranja";
                    cmb3[1] = "Lima";
                    barraStatRaza(1, 4, 4, 4, 2, 1, 1);
                    ageTextBox.Text = "60";
                    break;
                case 2://Doppelganger
                    cmb3 = new String[2];
                    cmb3[0] = "Tostada";
                    cmb3[1] = "Albina";
                    cmb4 = new String[2];
                    cmb4[0] = "Oro";
                    cmb4[1] = "Plata";
                    barraStatRaza(3, 5, 3, 3, 4, 1, 3);
                    ageTextBox.Text = "150";
                    break;
                case 3://Draconem
                    cmb3 = new String[5];
                    cmb3[0] = "Roja";
                    cmb3[1] = "Verde";
                    cmb3[2] = "Turquesa";
                    cmb3[3] = "Amarilla";
                    cmb3[4] = "Naranja";
                    cmb4 = new String[1];
                    cmb4[0] = "Sin Pelo";
                    barraStatRaza(4, 2, 3, 5, 3, 3, 2);
                    ageTextBox.Text = "40";
                    break;
                case 4://Eritum
                    cmb3 = new String[3];
                    cmb3[0] = "Dorada";
                    cmb3[1] = "Plateada";
                    cmb3[2] = "Cobre";
                    cmb4 = new String[1];
                    cmb4[0] = "Sin pelo";
                    barraStatRaza(3, 2, 2, 4, 5, 3, 1);
                    ageTextBox.Text = "120";
                    ageTextBox.ReadOnly = true;
                    break;
                case 5://Hiruden
                    barraStatRaza(3, 5, 3, 3, 4, 1, 2);
                    ageTextBox.Text = "";
                    ageTextBox.ReadOnly = false;
                    break;
                case 6://Humano
                    cmb3 = new String[4];
                    cmb3[0] = "Marfil";
                    cmb3[1] = "Clara";
                    cmb3[2] = "Oscura";
                    cmb3[3] = "Calida";
                    cmb4 = new String[5];
                    cmb4[0] = "Negro";
                    cmb4[1] = "Castaño";
                    cmb4[2] = "Rubio";
                    cmb4[3] = "Pelirrojo";
                    cmb4[4] = "Blanco";
                    barraStatRaza(2, 3, 3, 3, 3, 1, 1);
                    ageTextBox.Text = "20";
                    break;
                case 7://Iniuram
                    barraStatRaza(3, 4, 4, 3, 2, 2, 1);
                    break;
                case 8://Lupino
                    cmb3 = new String[1];
                    cmb3[0] = "Blanca";
                    cmb4 = new String[5];
                    cmb4[0] = "Albino";
                    cmb4[1] = "Gris";
                    cmb4[2] = "Marron";
                    cmb4[3] = "Marron Oscuro";
                    cmb4[4] = "Negro";
                    barraStatRaza(3, 2, 3, 5, 4, 2, 2);
                    ageTextBox.Text = "30";
                    break;
            }
            if (cmb3 != null)
            {
                skinComboBox.Items.AddRange(cmb3);
                skinComboBox.SelectedIndex = 0;
            }
            if (cmb4 != null)
            {
                hairComboBox.Items.AddRange(cmb4);
                hairComboBox.SelectedIndex = 0;
            }

            if (!progressBar2.Visible)
            {
                progressBar2.Visible = true;
                progressBar3.Visible = true;
                progressBar4.Visible = true;
                progressBar6.Visible = true;
                progressBar7.Visible = true;
                progressBar8.Visible = true;
                progressBar9.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (classComboBox.SelectedIndex)
            {
                case 0://Asesino
                    barraStatClase(4, 0, 0);
                    break;
                case 1://Guerrero
                    barraStatClase(5, 1, 0);
                    break;
                case 2://Invocador
                    barraStatClase(2, 0, 2);
                    break;
                case 3://Mago
                    barraStatClase(3, 0, 1);
                    break;
                case 4://Mistico
                    barraStatClase(3, 0, 1);
                    break;
                case 5://Monje
                    barraStatClase(4, 1, 1);
                    break;
                case 6://NoClass
                    barraStatClase(3, 0, 0);
                    break;
                case 7://Presagista
                    barraStatClase(2, 0, 1);
                    break;
                case 8://Quinetico
                    barraStatClase(3, 1, 0);
                    break;
                case 9://Tirador
                    barraStatClase(1, 0, 0);
                    break;
                case 10://Soul-Breaker
                    barraStatClase(4, 1, 1);
                    break;
                case 11://Yheri
                    barraStatClase(3, 0, 0);
                    break;
            }
            if (!progressBar5.Visible)
            {
                progressBar5.Visible = true;
            }
        }

        private void habilitarNext()
        {
            if ( (bool)generePanel.Tag && (bool)nameTextBox.Tag && (bool)choosedStatsPanel.Tag)
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        private void genereOnClick(object sender, EventArgs e)
        {
            generePanel.Tag = true;
            habilitarNext();
        }

        private void checkValueChange(object sender, EventArgs e)
        {
            decimal auxTag = (decimal)((NumericUpDown)sender).Tag,  aux = (decimal)((NumericUpDown)sender).Tag - ((NumericUpDown)sender).Value;

            if ( (totalStatsProgressBar.Value + aux > totalStatsProgressBar.Maximum) || (totalStatsProgressBar.Value + aux < totalStatsProgressBar.Minimum))
            {
                ((NumericUpDown)sender).Value = Convert.ToInt32( ((NumericUpDown)sender).Tag );
            }
            else
            {
                ((NumericUpDown)sender).Tag = ((NumericUpDown)sender).Value;
                updateProgressBar(Convert.ToInt32(aux));
            }
        }

        private void updateProgressBar(int value)
        {
            totalStatsProgressBar.Value += value;
            if (totalStatsProgressBar.Value == totalStatsProgressBar.Minimum)
            {
                choosedStatsPanel.Tag = true;
                habilitarNext();
            }
            else
            {
                choosedStatsPanel.Tag = false;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if( String.Equals( ((TextBox)sender).Text , "" ) )
            {
                nameTextBox.Tag = false;
            }
            else
            {
                nameTextBox.Tag = true;
            }
            habilitarNext();
        }
        
        private void statRandomButton_Click(object sender, EventArgs e)
        {
            int aux;
            foreach (Object ob in ((Control)((Button)sender).Parent).Controls)
            {
                if (ob is NumericUpDown)
                {
                    do
                    {
                        aux = rnd.Next(20);
                    } while (totalStatsProgressBar.Minimum > totalStatsProgressBar.Value - aux);
                    ((NumericUpDown)ob).Value = aux;
                }
            }
        }

        private void saveAction()
        {
            //new Personaje(nameTextBox.Text,classComboBox.Text,raceComboBox.Text,skinComboBox.Text,hairComboBox.Text,femaleRadioButton.Text,agilidadNumericUpDown.Value,carismaNumericUpDown.Value,combateNumericUpDown.Value,constitucionNumericUpDown.Value,destrezaNumericUpDown.Value,inteligenciaNumericUpDown.Value,invocacionNumericUpDown.Value,ingenioNumericUpDown.Value,fuerzaNumericUpDown.Value,percepcionNumericUpDown.Value,precisionNumericUpDown.Value,resistenciaNumericUpDown.Value,suerteNumericUpDown.Value);
        }
        
        private void createButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.circuloMagicoGreen;
            initCreatePj();
            previousButton.Enabled = false;
            previousButton.Visible = false;
            saveEndButton.Enabled = false;
            saveEndButton.Visible = false;
            selectPanel.Visible = false;
            firstCreationPanel.Visible = true;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            firstCreationPanel.Visible = false;
            secondCreationPanel.Visible = false;
            selectPanel.Visible = true;
        }

        private void saveEndButton_Click(object sender, EventArgs e)
        {
            saveAction();
            firstCreationPanel.Visible = false;
            secondCreationPanel.Visible = false;
            selectPanel.Visible = true;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            firstCreationPanel.Visible = false;
            secondCreationPanel.Visible = true;
            previousButton.Visible = true;
            previousButton.Enabled = true;
            saveEndButton.Visible = true;
            this.BackgroundImage = Properties.Resources.circuloMagicoRed;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            saveEndButton.Enabled = false;
            ((Control)sender).Visible = false;
            ((Control)sender).Enabled = false;
            firstCreationPanel.Visible = true;
            secondCreationPanel.Visible = false;
            this.BackgroundImage = Properties.Resources.circuloMagicoGreen;
        }
    }
}
