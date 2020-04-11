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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            HomeManagement management = new HomeManagement();
            management.TopLevel = false;
            mainPanel.Controls.Add(management);
            management.FormBorderStyle = FormBorderStyle.None;
            management.Dock = DockStyle.Fill;
            management.Show();


            
        }
    }
}
