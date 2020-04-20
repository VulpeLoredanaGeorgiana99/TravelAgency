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
    public partial class tabAddActiv : Form
    {
        public tabAddActiv()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
               textBox2.Text == "" ||
               textBox3.Text == "" ||
               textBox4.Text == "")  //descrierea este optionala
            {
                MessageBox.Show("Nu ati introdus datele corect. ");
            }
            else
        
            {

                using (SqlConnection dataConnection = new SqlConnection(Program.connetionString))
                {

                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {

                        dataCommand.CommandText = "INSERT INTO activitate(descr,adr_act,pret_unitate,oras) values(" +
                                                          "@descriere,@adresa,@pret,@oras)";
                        
                        dataCommand.Parameters.AddWithValue("@descriere", textBox1.Text);
                        dataCommand.Parameters.AddWithValue("@adresa", textBox2.Text);
                        dataCommand.Parameters.AddWithValue("@pret", Convert.ToDecimal(textBox3.Text));
                        dataCommand.Parameters.AddWithValue("@oras", textBox4.Text);
                    

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
