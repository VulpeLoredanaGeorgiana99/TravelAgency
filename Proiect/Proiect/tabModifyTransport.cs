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
    public partial class tabModifyTransport : Form
    {
        //string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ANU3\semestrul2\PAOO\TravelAgency\Proiect\Proiect\Database1.mdf;Integrated Security=True";
        private int n;

        public tabModifyTransport()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Nu ati introdus ID-ul unic al zboorului." +
                    "TIP : Acesta se gaseste in sectiunea vizualizare :) ");
            }
            else if(!int.TryParse(textBox6.Text, out n))
            {
                MessageBox.Show("Durata nu este numar. ");
            }
          else if (textBox2.Text != "" || (textBox6.Text != "" && int.TryParse(textBox6.Text, out n)))  //exista descriere
            {

                using (SqlConnection dataConnection = new SqlConnection(Program.connetionString))
                {

                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {
                        String comma = ((textBox2.Text != "") && (textBox6.Text != "")) ? " , " : "";
                        dataCommand.CommandText = "UPDATE transport SET" +
                        (textBox2.Text != "" ? " descr = @descriere " : "") +
                        comma +
                        (textBox6.Text != "" ? " durata_zbor = @durata " : "") +
                        "WHERE id_t = @id";



                        dataCommand.Parameters.AddWithValue("@descriere", textBox2.Text);
                        if (textBox6.Text != "")
                        {
                            dataCommand.Parameters.AddWithValue("@durata", Convert.ToDecimal(textBox6.Text));
                        }

                        dataCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textBox7.Text));

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
