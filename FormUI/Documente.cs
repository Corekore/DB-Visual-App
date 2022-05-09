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
    public partial class Documente : Form
    {
        List<DocumenteShow> documente = new List<DocumenteShow>();
        public Form _menu;
        public Documente()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            documenteFoundListbox.DataSource = documente;
            documenteFoundListbox.DisplayMember = "AngajatInfo";
        }

        private void SearchallAngButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            documente = db.GetDocumente();
            documenteFoundListbox.DataSource = documente;
            documenteFoundListbox.DisplayMember = "DocumenteInfo";
        }

        private void insertDocButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertDocumente(int.Parse(documenteidDocText.Text), buletinDocText.Text, arcDocText.Text, actejuridiceDocText.Text, adeverintasalariatDocText.Text, contractangajatorDocText.Text, alteacteDocText.Text);
            documenteidDocText.Text = "";
            buletinDocText.Text = "";
            arcDocText.Text = "";
            actejuridiceDocText.Text = "";
            adeverintasalariatDocText.Text = "";
            contractangajatorDocText.Text = "";
            alteacteDocText.Text = "";
        }

        private void deleteDocButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteDocumente(int.Parse(documenteidDocText.Text));
            documenteidDocText.Text = "";
        }

        private void backDocButton_Click(object sender, EventArgs e)
        {
            if (_menu == null)
                _menu = new Menu();
            Hide();
            _menu.Show();
        }
    }
}
