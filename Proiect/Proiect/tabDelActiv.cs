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
    public partial class tabDelActiv : Form
    {
        public tabDelActiv()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out int m))
            {
                MessageBox.Show("Nu ati introdus ID-ul unic al activitatii." +
                    "TIP : Acesta se gaseste in sectiunea vizualizare :) ");
            }
            else

            {

                using (SqlConnection dataConnection = new SqlConnection(Program.connetionString))
                {

                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {

                        dataCommand.CommandText = "DELETE FROM activitate WHERE id_act = @id";
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
