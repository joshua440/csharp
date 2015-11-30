using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniPracticaBotonera
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList nameList = new ArrayList();
            textBox.Tag = nameList;
            cancelButton.Tag = false;
            saveButton.Tag = false;
            seeButton.Tag = 0;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            textBox.ReadOnly = false;
            newButton.Enabled = false;
            saveButton.Enabled = false;
            saveButton.Tag = false;
            cancelButton.Enabled = true;
            cancelButton.Tag = false;
            seeButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if ((bool)saveButton.Tag) {
                ((ArrayList)(textBox.Tag)).RemoveAt((int)seeButton.Tag);
                ((ArrayList)(textBox.Tag)).Insert((int)seeButton.Tag, new Alumno(textBox.Text));
            }
            else
            {
                ((ArrayList)(textBox.Tag)).Add(new Alumno(textBox.Text));
            }
            textBox.ReadOnly = true;
            textBox.Text = "";
            newButton.Enabled = true;
            saveButton.Enabled = false;
            cancelButton.Enabled = false;
            seeButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if ((bool)cancelButton.Tag)
            {
                saveButton.Enabled = false;
                cancelButton.Enabled = false;
                editButton.Enabled = true;
                deleteButton.Enabled = true;
                textBox.ReadOnly = true;
                textBox.Text = ((Alumno)((ArrayList)(textBox.Tag))[(int)seeButton.Tag]).getName();
                if ((int)seeButton.Tag> 0){
                    backButton.Enabled = true;
                }
                if ((int)seeButton.Tag < ((ArrayList)(textBox.Tag)).Count)
                {
                    nextButton.Enabled = true;
                }
            }
            else
            {
                textBox.ReadOnly = true;
                saveButton.Enabled = false;
                cancelButton.Enabled = false;
                newButton.Enabled = true;
            }
        }

        private void seeButton_Click(object sender, EventArgs e)
        {
            textBox.Text=((Alumno)((ArrayList)(textBox.Tag))[0]).getName();
            seeButton.Tag = 0;
            if ( ((ArrayList)(textBox.Tag)).Count > 1 )
            {
                nextButton.Enabled = true;
            }
            newButton.Enabled = false;
            outSeeButton.Enabled = true;
            saveButton.Enabled = false;
            cancelButton.Enabled = false;
            seeButton.Enabled = false;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            textBox.ReadOnly = false;

            seeButton.Enabled = false;
            deleteButton.Enabled = false;
            nextButton.Enabled = false;
            backButton.Enabled = false;
            editButton.Enabled = false;
            outSeeButton.Enabled = false;

            saveButton.Enabled = true;
            saveButton.Tag = true;
            cancelButton.Enabled = true;
            cancelButton.Tag = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ((ArrayList)(textBox.Tag)).RemoveAt((int)seeButton.Tag);
            if ( ((ArrayList)(textBox.Tag)).Count > 1 )
            {
                if (((ArrayList)(textBox.Tag)).Count - 1 == (int)seeButton.Tag)
                {
                    seeButton.Tag = (int)seeButton.Tag - 1;
                }
                textBox.Text = ((Alumno)((ArrayList)(textBox.Tag))[(int)seeButton.Tag]).getName();
            }
            else
            {
                outSeeButton.Enabled = false;
                nextButton.Enabled = false;
                seeButton.Enabled = false;
                deleteButton.Enabled = false;
                editButton.Enabled = false;
                newButton.Enabled = true;
                textBox.Text = "";
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if ( ((ArrayList)(textBox.Tag)).Count > (int)seeButton.Tag )
            {
                seeButton.Tag = (int)seeButton.Tag + 1;
                textBox.Text = ( (Alumno) ((ArrayList)textBox.Tag)[(int)seeButton.Tag] ).getName();
                backButton.Enabled = true;
                if (((ArrayList)(textBox.Tag)).Count - 1 == (int)seeButton.Tag)
                {
                    nextButton.Enabled = false;
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (0 < (int)seeButton.Tag)
            {
                seeButton.Tag = (int)seeButton.Tag - 1;
                textBox.Text = ((Alumno)((ArrayList)(textBox.Tag))[(int)seeButton.Tag]).getName();
                nextButton.Enabled = true;
                if ( 0 == (int)seeButton.Tag)
                {
                    backButton.Enabled = false;
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                saveButton.Enabled = false;
            }
            else
            {
                saveButton.Enabled = true;
            }
        }

        private void outSeeButton_Click(object sender, EventArgs e)
        {
            newButton.Enabled = true;
            nextButton.Enabled = false;
            backButton.Enabled = false;
            deleteButton.Enabled = false;
            editButton.Enabled = false;
            outSeeButton.Enabled = false;
            textBox.Text = "";
        }
    }
}
