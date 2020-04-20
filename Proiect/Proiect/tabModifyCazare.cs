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
    public partial class tabModifyCazare : Form
    {
       // string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ANU3\semestrul2\PAOO\TravelAgency\Proiect\Proiect\Database1.mdf;Integrated Security=True";
        public tabModifyCazare()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if  (textBox7.Text == "")  
            {
                MessageBox.Show("Nu ati introdus ID-ul unic al cazarii." +
                    "TIP : Acesta se gaseste in sectiunea vizualizare :) ");
            }
            else
            if (textBox2.Text != "" || textBox6.Text !="")  //exista descriere
            {

                using (SqlConnection dataConnection = new SqlConnection(Program.connetionString))
                {

                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {
                    String comma = ((textBox2.Text != "") && (textBox6.Text != "")) ? " , " : "";
                        dataCommand.CommandText = "UPDATE cazare SET" +
                        (textBox2.Text!=""? " descr = @descriere " : "") +
                        comma +
                        (textBox6.Text != "" ? " pret__unitate = @pret " : "") +
                        "WHERE id_caz = @id";
                                                         

                        
                        dataCommand.Parameters.AddWithValue("@descriere", textBox2.Text);
                        if (textBox6.Text != "")
                        {
                            dataCommand.Parameters.AddWithValue("@pret", Convert.ToDecimal(textBox6.Text));
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
