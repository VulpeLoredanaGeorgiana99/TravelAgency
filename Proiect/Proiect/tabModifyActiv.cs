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
    public partial class tabModifyActiv : Form
    {
        public tabModifyActiv()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Nu ati introdus ID-ul unic al activitatii." +
                    "TIP : Acesta se gaseste in sectiunea vizualizare :) ");
            }
            else if(textBox1.Text == "")
            {
                MessageBox.Show("Nu ati introdus niciun pret (numar)");
            }
            else
           
            {

                using (SqlConnection dataConnection = new SqlConnection(Program.connetionString))
                {

                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {

                        dataCommand.CommandText = "UPDATE activitate SET pret_unitate = @pret where id_act = @id";

                        dataCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textBox2.Text));
                        dataCommand.Parameters.AddWithValue("@pret", Convert.ToDecimal(textBox1.Text));

                        dataConnection.Open();
                        dataCommand.ExecuteNonQuery();

                        dataConnection.Close();
                        MessageBox.Show("S-a modificat cu succes!");

                    }
                }



            }



        }
    }
}
