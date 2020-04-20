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
    public partial class tabViewTransport : Form
    {
        public tabViewTransport()
        {
            InitializeComponent();
        }

        private void tabViewTransport_Load(object sender, EventArgs e)
        {

            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ANU3\semestrul2\PAOO\TravelAgency\Proiect\Proiect\Database1.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(Program.connetionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM TRANSPORT", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
