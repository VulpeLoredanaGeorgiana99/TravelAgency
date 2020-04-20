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
    public partial class tabDeleteTransport : Form
    {
        private int n;
        public tabDeleteTransport()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && int.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Nu ati introdus ID-ul unic al transportului." +
                    "TIP : Acesta se gaseste in sectiunea vizualizare :) ");
            }
            else if(!int.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Introduceti va rog un numar ! ");
            }
            else
            {
                
                using (SqlConnection dataConnection = new SqlConnection(Program.connetionString))
                {

                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {

                        dataCommand.CommandText = "DELETE FROM transport WHERE id_t = @id";
                        dataCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));

                        dataConnection.Open();
                        dataCommand.ExecuteNonQuery();

                        dataConnection.Close();
                        MessageBox.Show("S-a sters cu succes!");



                    }
                }



            }
        }
    }
}
