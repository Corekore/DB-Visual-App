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
    public partial class Reprezentant : Form
    {
        List<ReprezentantShow> reprezentant = new List<ReprezentantShow>();
        public Form _menu;
        public Reprezentant()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            reprezentantFoundListbox.DataSource = reprezentant;
            reprezentantFoundListbox.DisplayMember = "ReprezentantInfo";
        }

        private void searchallRepButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            reprezentant = db.GetReprezentant();
            reprezentantFoundListbox.DataSource = reprezentant;
            reprezentantFoundListbox.DisplayMember = "ReprezentantInfo";
        }

        private void insertRepButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertReprezentant(int.Parse(reprezentantidRepText.Text), numeRepText.Text, prenumeRepText.Text, cnpRepText.Text, stradaRepText.Text, numarRepText.Text, orasRepText.Text, sexRepText.Text, dataRepText.Text);
            reprezentantidRepText.Text = "";
            numeRepText.Text = "";
            prenumeRepText.Text = "";
            cnpRepText.Text = "";
            stradaRepText.Text = "";
            numarRepText.Text = "";
            orasRepText.Text = "";
            sexRepText.Text = "";
            dataRepText.Text = "";
        }

        private void deleteRepButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteReprezentant(int.Parse(reprezentantidRepText.Text));
            reprezentantidRepText.Text = "";
        }

        private void backRepButton_Click(object sender, EventArgs e)
        {
            if (_menu == null)
                _menu = new Menu();
            Hide();
            _menu.Show();
        }
    }
}
