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
    public partial class tabAddCazare : Form
    { int rank;
        public tabAddCazare()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "" ||
                textBox5.Text == "" ||
                textBox6.Text == "")  //descrierea este optionala
            {
                MessageBox.Show("Nu ati introdus datele corect. ");
            }
            else 
            if(textBox2.Text != "")
            {
                
                using (SqlConnection dataConnection = new SqlConnection(connetionString))
                {
                    
                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {
                        
                        dataCommand.CommandText = "INSERT INTO cazare(nume,descr,adr_caz,tel,oras,pret__unitate) values(" +
                                                          "@nume,@descriere,@adresa,@tel,@oras,@pret)";

                        dataCommand.Parameters.AddWithValue("@rank", rank);
                        dataCommand.Parameters.AddWithValue("@nume", textBox1.Text);
                        dataCommand.Parameters.AddWithValue("@descriere", textBox2.Text);
                        dataCommand.Parameters.AddWithValue("@adresa", textBox3.Text);
                        dataCommand.Parameters.AddWithValue("@tel", textBox4.Text);
                        dataCommand.Parameters.AddWithValue("@oras", textBox5.Text);
                        dataCommand.Parameters.AddWithValue("@pret", Convert.ToDecimal(textBox6.Text));

                        dataConnection.Open();
                        dataCommand.ExecuteNonQuery();

                        dataConnection.Close();
                        MessageBox.Show("S-a inserat cu succes!");

                    }
                }
                

                  
            }else if(textBox2.Text == "")
            {
                using (SqlConnection dataConnection = new SqlConnection(connetionString))
                {

                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {

                        dataCommand.CommandText = "INSERT INTO cazare(nume,adr_caz,tel,oras,pret__unitate) values(" +
                                                          "@nume,@adresa,@tel,@oras,@pret)";

                        dataCommand.Parameters.AddWithValue("@rank", rank);
                        dataCommand.Parameters.AddWithValue("@nume", textBox1.Text);
                        dataCommand.Parameters.AddWithValue("@adresa", textBox3.Text);
                        dataCommand.Parameters.AddWithValue("@tel", textBox4.Text);
                        dataCommand.Parameters.AddWithValue("@oras", textBox5.Text);
                        dataCommand.Parameters.AddWithValue("@pret", Convert.ToDecimal(textBox6.Text));

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
