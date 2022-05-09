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
    public partial class Simple : Form
    {
        List<Client> client = new List<Client>();
        List<ReprezentantShow> reprezentant = new List<ReprezentantShow>();
        public Form _menu;
        public Simple()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            simpleFoundListbox.DataSource = client;
            simpleFoundListbox.DisplayMember = "SimpleInfo1";
        }
        private void UpdateBindingReprezentant()
        {
            simpleFoundListbox.DataSource = reprezentant;
            simpleFoundListbox.DisplayMember = "SimpleInfo1";
        }

        private void backSimButton_Click(object sender, EventArgs e)
        {
            if (_menu == null)
                _menu = new Menu();
            Hide();
            _menu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            client = db.GetInfo1();
            UpdateBinding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            client = db.GetInfo2();
            UpdateBinding();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            reprezentant = db.GetInfo3();
            UpdateBindingReprezentant();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            client = db.GetInfo4();
            UpdateBinding();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            client = db.GetInfo5();
            UpdateBinding();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            client = db.GetInfo6();
            UpdateBinding();
        }
    }
}
