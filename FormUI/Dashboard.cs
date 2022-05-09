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
    public partial class Dashboard : Form
    {
        List<Client> client = new List<Client>();
        public Form _menu;
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            clientFoundListbox.DataSource = client;
            clientFoundListbox.DisplayMember = "NumeClientInfo";
        }
        private void Search_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            client = db.GetClientByName(clientText.Text);
            UpdateBinding();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertClient(int.Parse(clientidText.Text), int.Parse(reprezentantidText.Text), numeText.Text, prenumeText.Text, cnpText.Text, stradaText.Text, numarText.Text, orasText.Text, sexText.Text, dataText.Text);
            clientidText.Text = "";
            reprezentantidText.Text = "";
            numeText.Text = "";
            prenumeText.Text = "";
            cnpText.Text = "";
            stradaText.Text = "";
            numarText.Text = "";
            orasText.Text = "";
            sexText.Text = "";
            dataText.Text = "";
        }

        private void searchallButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            client = db.GetClient();
            clientFoundListbox.DataSource = client;
            clientFoundListbox.DisplayMember = "ClientInfo";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteClient(int.Parse(clientidText.Text));
            clientidText.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (_menu == null)
                _menu = new Menu();
            Hide();
            _menu.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.UpdateClient(int.Parse(clientidText.Text),int.Parse(reprezentantidText.Text), numeText.Text, prenumeText.Text, cnpText.Text, stradaText.Text, numarText.Text, orasText.Text, sexText.Text, dataText.Text);
            clientidText.Text = "";
            reprezentantidText.Text = "";
            numeText.Text = "";
            prenumeText.Text = "";
            cnpText.Text = "";
            stradaText.Text = "";
            numarText.Text = "";
            orasText.Text = "";
            sexText.Text = "";
            dataText.Text = "";
        }
    }
}
