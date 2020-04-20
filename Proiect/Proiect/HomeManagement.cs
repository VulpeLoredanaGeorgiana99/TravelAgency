using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        

        private void metroButton4_Click(object sender, EventArgs e)
        {
            panelCazare.Controls.Clear();

            tabViewCazare tabViewCazare = new tabViewCazare();
            tabViewCazare.TopLevel = false;
            panelCazare.Controls.Add(tabViewCazare);
            tabViewCazare.FormBorderStyle = FormBorderStyle.None;
            tabViewCazare.Dock = DockStyle.Fill;
            tabViewCazare.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            panelCazare.Controls.Clear();

            tabModifyCazare tabModifyCazare = new tabModifyCazare();
            tabModifyCazare.TopLevel = false;
            panelCazare.Controls.Add(tabModifyCazare);
            tabModifyCazare.FormBorderStyle = FormBorderStyle.None;
            tabModifyCazare.Dock = DockStyle.Fill;
            tabModifyCazare.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            panelCazare.Controls.Clear();

            tabDeleteCazare tabDeleteCazare = new tabDeleteCazare();
            tabDeleteCazare.TopLevel = false;
            panelCazare.Controls.Add(tabDeleteCazare);
            tabDeleteCazare.FormBorderStyle = FormBorderStyle.None;
            tabDeleteCazare.Dock = DockStyle.Fill;
            tabDeleteCazare.Show();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            panelTransport.Controls.Clear();

            tabAddTransport tabAddTransport = new tabAddTransport();
            tabAddTransport.TopLevel = false;
            panelTransport.Controls.Add(tabAddTransport);
            tabAddTransport.FormBorderStyle = FormBorderStyle.None;
            tabAddTransport.Dock = DockStyle.Fill;
            tabAddTransport.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            panelTransport.Controls.Clear();

            tabViewTransport tabViewTransport = new tabViewTransport();
            tabViewTransport.TopLevel = false;
            panelTransport.Controls.Add(tabViewTransport);
            tabViewTransport.FormBorderStyle = FormBorderStyle.None;
            tabViewTransport.Dock = DockStyle.Fill;
            tabViewTransport.Show();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            panelTransport.Controls.Clear();

            tabModifyTransport tabModifyTransport = new tabModifyTransport();
            tabModifyTransport.TopLevel = false;
            panelTransport.Controls.Add(tabModifyTransport);
            tabModifyTransport.FormBorderStyle = FormBorderStyle.None;
            tabModifyTransport.Dock = DockStyle.Fill;
            tabModifyTransport.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            panelTransport.Controls.Clear();

            tabDeleteTransport tabDeleteTransport = new tabDeleteTransport();
            tabDeleteTransport.TopLevel = false;
            panelTransport.Controls.Add(tabDeleteTransport);
            tabDeleteTransport.FormBorderStyle = FormBorderStyle.None;
            tabDeleteTransport.Dock = DockStyle.Fill;
            tabDeleteTransport.Show();
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {

            panelActivitati.Controls.Clear();

            tabAddActiv tabAddActiv = new tabAddActiv();
            tabAddActiv.TopLevel = false;
            panelActivitati.Controls.Add(tabAddActiv);
            tabAddActiv.FormBorderStyle = FormBorderStyle.None;
            tabAddActiv.Dock = DockStyle.Fill;
            tabAddActiv.Show();
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            panelActivitati.Controls.Clear();

            tabModifyActiv tabModifyActiv = new tabModifyActiv();
            tabModifyActiv.TopLevel = false;
            panelActivitati.Controls.Add(tabModifyActiv);
            tabModifyActiv.FormBorderStyle = FormBorderStyle.None;
            tabModifyActiv.Dock = DockStyle.Fill;
            tabModifyActiv.Show();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            panelActivitati.Controls.Clear();

            tabViewActiv tabViewActiv = new tabViewActiv();
            tabViewActiv.TopLevel = false;
            panelActivitati.Controls.Add(tabViewActiv);
            tabViewActiv.FormBorderStyle = FormBorderStyle.None;
            tabViewActiv.Dock = DockStyle.Fill;
            tabViewActiv.Show();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            panelActivitati.Controls.Clear();

            tabDelActiv tabDelActiv = new tabDelActiv();
            tabDelActiv.TopLevel = false;
            panelActivitati.Controls.Add(tabDelActiv);
            tabDelActiv.FormBorderStyle = FormBorderStyle.None;
            tabDelActiv.Dock = DockStyle.Fill;
            tabDelActiv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mainPanel.Controls.Clear();
            this.Controls.Clear();

            Login login = new Login();
            login.TopLevel = false;
            this.Controls.Add(login);
            login.FormBorderStyle = FormBorderStyle.None;
            login.Dock = DockStyle.Fill;
            login.Show();
        }
    }
}
