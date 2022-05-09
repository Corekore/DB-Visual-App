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
    public partial class Menu : Form
    {
        private Form _client;
        private Form _angajat;
        private Form _reprezentant;
        private Form _documente;
        private Form _istoric;
        private Form _simple;
        private Form _complexe;

        public Menu()
        {
            InitializeComponent();
        }

        private void menuClientButton_Click(object sender, EventArgs e)
        {
            if (_client == null)
                _client = new Dashboard();
            Hide();
            _client.Show();
        }

        private void menuAngajatButton_Click(object sender, EventArgs e)
        {
            if (_angajat == null)
                _angajat = new Angajat();
            Hide();
            _angajat.Show();
        }

        private void menuReprezentantButton_Click(object sender, EventArgs e)
        {
            if (_reprezentant == null)
                _reprezentant = new Reprezentant();
            Hide();
            _reprezentant.Show();
        }

        private void menuDocumenteButton_Click(object sender, EventArgs e)
        {
            if (_documente == null)
                _documente = new Documente();
            Hide();
            _documente.Show();
        }

        private void menuIstoricButton_Click(object sender, EventArgs e)
        {
            if (_istoric == null)
                _istoric = new Istoric();
            Hide();
            _istoric.Show();
        }

        private void menuSimpleButton_Click(object sender, EventArgs e)
        {
            if (_simple == null)
                _simple = new Simple();
            Hide();
            _simple.Show();
        }
    }
}
