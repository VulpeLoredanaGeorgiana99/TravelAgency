using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class HomeManagement : Form
    {
        public HomeManagement()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            panelCazare.Controls.Clear();

            tabAddCazare addCazare = new tabAddCazare();
            addCazare.TopLevel = false;
            panelCazare.Controls.Add(addCazare);
            addCazare.FormBorderStyle = FormBorderStyle.None;
            addCazare.Dock = DockStyle.Fill;
            addCazare.Show();

        }
    }
}
