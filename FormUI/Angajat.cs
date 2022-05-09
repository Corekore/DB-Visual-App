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
    public partial class Angajat : Form
    {
        List<AngajatShow> angajat = new List<AngajatShow>();
        public Form _menu;
        public Angajat()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            angajatFoundListbox.DataSource = angajat;
            angajatFoundListbox.DisplayMember = "AngajatInfo";
        }

        private void searchallAngButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            angajat = db.GetAngajat();
            angajatFoundListbox.DataSource = angajat;
            angajatFoundListbox.DisplayMember = "AngajatInfo";
        }

        private void insertAngButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertAngajat(int.Parse(angajatidAngText.Text), numeAngText.Text, prenumeAngText.Text, int.Parse(clientidAngText.Text));
            angajatidAngText.Text = "";
            numeAngText.Text = "";
            prenumeAngText.Text = "";
            clientidAngText.Text = "";
        }

        private void deleteAngButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteAngajat(int.Parse(angajatidAngText.Text));
            angajatidAngText.Text = "";
        }

        private void backAngButton_Click(object sender, EventArgs e)
        {
            if (_menu == null)
                _menu = new Menu();
            Hide();
            _menu.Show();
        }

        private void updateAngButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.UpdateAngajat(int.Parse(angajatidAngText.Text), numeAngText.Text, prenumeAngText.Text, int.Parse(clientidAngText.Text));
            angajatidAngText.Text = "";
            numeAngText.Text = "";
            prenumeAngText.Text = "";
            clientidAngText.Text = "";
        }
    }
}
