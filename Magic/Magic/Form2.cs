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

namespace Magic
{
    public partial class Form2 : Form
    {

        private int noChangeUser=0;
        private String user;

        public Form2()
        {
            InitializeComponent();
        }

        public void setUser(String user)
        {
            if (noChangeUser==0)
            {
                this.user = user;
                noChangeUser++;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            colorComboBox.SelectedIndex=0;
            loadUserCards();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Form1)Tag).backToLogin();
            ((Form1)Tag).Show();
            this.Close();
        }

        private void showCard(){
            Form3 form3 = new Form3();
            form3.FormClosed += (s, args) => this.Show();
            form3.Tag = this;
            this.Hide();
            form3.Show();
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bddListBox.Items.Clear();
            ArrayList cards;
            if (!String.Equals(colorComboBox.Text,"Todos"))
            {
                cards = Bdd.selectColsReader(String.Format("select * from Card where color='{0}' and name not in (select nameCard from UserCard where nameUser='{1}');", colorComboBox.Text, user));
            }
            else
            {
                cards = Bdd.selectColsReader(String.Format("select * from Card where name not in (select nameCard from UserCard where nameUser='{0}');", user));
            }
                
            foreach (Card card in cards)
            {
                bddListBox.Items.Add(card.getName());
            }
            bddListBox.Tag = cards;
        }

        public void loadUserCards()
        {
            userListBox.Items.Clear();
            ArrayList cards;
            cards = Bdd.selectColsReader(String.Format("select * from Card where color='{0}' and name in (select nameCard from UserCard where nameUser='{1}');", colorComboBox.Text, user));
            foreach (Card card in cards)
            {
                userListBox.Items.Add(card.getName());
            }
            userListBox.Tag = cards;
        }

        private void textBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left&&((ListBox)sender).SelectedItem!=null)
            {
                DoDragDrop(((ListBox)sender).SelectedItem.ToString(),DragDropEffects.All);
            } else if (e.Button==MouseButtons.Right)
            {
                ((ListBox)sender).SetSelected(((ListBox)sender).IndexFromPoint(e.Location),true);
            }
        }
    }
}
