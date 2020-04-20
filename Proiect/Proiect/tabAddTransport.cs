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
    public partial class tabAddTransport : Form
    {
       // string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ANU3\semestrul2\PAOO\TravelAgency\Proiect\Proiect\Database1.mdf;Integrated Security=True";

        public tabAddTransport()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "" ||
                    textBox3.Text == "" ||
                    textBox4.Text == "" ||
                    textBox5.Text == ""
                    )  
                {
                    MessageBox.Show("Nu ati introdus datele corect. ");
                }
                else

            {
                
                using (SqlConnection dataConnection = new SqlConnection(Program.connetionString))
                    {

                        using (SqlCommand dataCommand = dataConnection.CreateCommand())
                        {

                            dataCommand.CommandText = "INSERT INTO transport(plecare,destinatie,companie,durata_zbor,descr) values(" +
                                                              "@plecare,@destinatie,@companie,@durata,@descriere)";

                          
                            dataCommand.Parameters.AddWithValue("@plecare", textBox1.Text);
                            dataCommand.Parameters.AddWithValue("@destinatie", textBox2.Text);
                            dataCommand.Parameters.AddWithValue("@companie", textBox3.Text);
                            dataCommand.Parameters.AddWithValue("@durata", Convert.ToDecimal(textBox4.Text));
                            dataCommand.Parameters.AddWithValue("@descriere", textBox5.Text);
                            //dataCommand.Parameters.AddWithValue("@pret", Convert.ToDecimal(textBox6.Text));

                            dataConnection.Open();
                            dataCommand.ExecuteNonQuery();

                            dataConnection.Close();
                            MessageBox.Show("S-a inserat cu succes!");

                        }
                    }



                }
               




            
        }
    }
}
