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
    public partial class Istoric : Form
    {
        List<IstoricShow> istoric = new List<IstoricShow>();
        public Form _menu;
        public Istoric()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            istoricFoundListbox.DataSource = istoric;
            istoricFoundListbox.DisplayMember = "IstoricInfo";
        }

        private void searchallIstButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            istoric = db.GetIstoric();
            istoricFoundListbox.DataSource = istoric;
            istoricFoundListbox.DisplayMember = "IstoricInfo";
        }

        private void insertIstButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertIstoric(int.Parse(contractidIstText.Text), int.Parse(clientidIstText.Text), tipcontractIstText.Text, datadeschidereIstText.Text, starecontractIstText.Text);
            contractidIstText.Text = "";
            clientidIstText.Text = "";
            tipcontractIstText.Text = "";
            datadeschidereIstText.Text = "";
            starecontractIstText.Text = "";
        }

        private void deleteIstButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteIstoric(int.Parse(contractidIstText.Text));
            contractidIstText.Text = "";
        }

        private void backIstButton_Click(object sender, EventArgs e)
        {
            if (_menu == null)
                _menu = new Menu();
            Hide();
            _menu.Show();
        }
    }
}
