using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Login : Form
    {
        //private Form _dashboard;
        private Form _menu;
       
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = "user2";
            string password = "1234";
            string username1 = "admin";
            string password1 = "12345";
            if ((String.Equals(usernameText.Text, username) && String.Equals(passwordText.Text, password)) || 
                (String.Equals(usernameText.Text, username1) && String.Equals(passwordText.Text, password1)))
            {
                usernameText.Text = "";
                passwordText.Text = "";
                if (_menu == null)
                    _menu = new Menu();
                Hide();
                _menu.Show();
            }
            else {
                MessageBox.Show("Wrong Username or Password!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
