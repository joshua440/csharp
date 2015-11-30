using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Magic
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bdd.addBdd(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename ='C:\Users\joshu\Documents\Visual Studio 2015\Projects\Magic\Magic\MagicBdd.mdf'; Integrated Security = True; Connect Timeout = 30"); 
        }

        private void enableLogIn(object sender, EventArgs e)
        {
            if ( userTextBox.Text == "" || passwordTextBox.Text == "")
            {
                loginButton.Enabled = false;
            }
            else
            {
                loginButton.Enabled = true;
            }
        }

        private void connect(object sender, EventArgs e)
        {
            if (Bdd.selectScalar(String.Format("select count(*) from \"User\" where name='{0}' and password='{1}';", userTextBox.Text, passwordTextBox.Text))==1)
            {
                Form2 form2 = new Form2();
                form2.FormClosed += (s, args) => this.Show();
                form2.setUser(userTextBox.Text);
                form2.Tag = this;
                this.Hide();
                form2.Show();
            }
           
        }

        public void backToLogin()
        {
            if (!rememberCheckBox.Checked)
            {
                userTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }
    }
}
