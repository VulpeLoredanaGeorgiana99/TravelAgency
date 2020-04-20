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
using System.Net.Mail;
namespace Proiect
{
    public partial class HomeOperation : Form
    {
        public HomeOperation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {   Program.cazare.ID = row.Cells[0].Value.ToString();
                Program.cazare.Nume = row.Cells[1].Value.ToString();
                Program.cazare.Descriere = row.Cells[2].Value.ToString();
                Program.cazare.Adresa = row.Cells[3].Value.ToString();
                Program.cazare.Telefon = row.Cells[4].Value.ToString();
                Program.cazare.Oras = row.Cells[5].Value.ToString();
                Program.cazare.Pret = Convert.ToDecimal(Convert.ToDecimal(row.Cells[6].Value.ToString()) * Convert.ToDecimal(textBox7.Text.ToString()));

                MessageBox.Show(Program.cazare.ToString());


            }
        }


        
        private void metroTabControl1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(Program.connetionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM CAZARE", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();

                sqlCon.Open();
                SqlDataAdapter sqlTr = new SqlDataAdapter("SELECT * FROM TRANSPORT", sqlCon);
                DataTable DBTR = new DataTable();
                sqlTr.Fill(DBTR);

                dataGridView2.DataSource = DBTR;
                sqlCon.Close();

                sqlCon.Open();
                SqlDataAdapter sqlAc = new SqlDataAdapter("SELECT * FROM ACTIVITATE", sqlCon);
                DataTable DBAC = new DataTable();
                sqlAc.Fill(DBAC);

                dataGridView3.DataSource = DBAC;
                sqlCon.Close();
            }


        }

       
        

        private void button2_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {   Program.transport.ID = row.Cells[0].Value.ToString();
                Program.transport.Plecare = row.Cells[1].Value.ToString();
                Program.transport.Destinatie = row.Cells[2].Value.ToString();
                Program.transport.Companie = row.Cells[3].Value.ToString();
                Program.transport.DurataZbor = Convert.ToDecimal(row.Cells[4].Value.ToString());
                Program.transport.Descriere = row.Cells[5].Value.ToString();

                MessageBox.Show(Program.transport.ToString());


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {   Program.activitate.ID = row.Cells[0].Value.ToString();
                Program.activitate.Descriere = row.Cells[1].Value.ToString();
                Program.activitate.Adresa = row.Cells[2].Value.ToString();
                Program.activitate.Pret = Convert.ToDecimal(row.Cells[3].Value.ToString());
                Program.activitate.Oras = row.Cells[4].Value.ToString();

                MessageBox.Show(Program.activitate.ToString());


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            String Date = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");
            Program.myObj.Data = Date;

            if(textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0)
            {
                Program.myObj.Name = textBox1.Text;
                Program.myObj.Prenume = textBox2.Text;
                Program.myObj.Adresa = textBox3.Text;
            }

            if(long.TryParse(textBox4.Text,out long n) && textBox4.Text != ""){
                Program.myObj.Telefon = textBox4.Text;
            }
            else
            {
                MessageBox.Show("Numar de telefon gresit/neintrodus ! ");
            }

            if(textBox5.Text.Length == 8)
            {
                Program.myObj.SerieCI = textBox5.Text;
            }
            else
            {
                MessageBox.Show("Serie CI gresita/neintrodusa ! ");
            }

            if (textBox6.Text.Contains("@") && textBox6.Text.Length != 0)
            {
                Program.myObj.Email = textBox6.Text;
            }
            else
            {
                MessageBox.Show("Nu este email");
            }
          

            MessageBox.Show(Program.myObj.ToString());
        }

        private void metroTabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text += Program.myObj.ToString();
            if (Program.cazare != null)
            {
                richTextBox1.Text += Program.cazare.ToString();
            } 
            if(Program.transport != null)
            {
                richTextBox1.Text += Program.transport.ToString();
            }
            if(Program.activitate != null)
            {
                richTextBox1.Text += Program.activitate.ToString();
            }
          

            
        }

        private void rezerbaBtn_Click(object sender, EventArgs e)
        {
            Boolean isCazare = false;
            Boolean isTransport = false;
            Boolean isActivitate = false;

            if(Program.cazare != null)
            {
                isCazare = true;
            }

            if (Program.transport != null)
            {
                isTransport = true;
            }

            if (Program.activitate != null)
            {
                isActivitate = true;
            }

            if(isCazare && isTransport && isActivitate)
            {
                using (SqlConnection dataConnection = new SqlConnection(Program.connetionString))
                {

                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {

                        dataCommand.CommandText = "INSERT INTO rezervare(data_inceput,id_t,id_c,id_ac,nume_client) values(" +
                                                          "@data,@idT,@idC,@idAc,@nume_client)";
                        String Date = monthCalendar2.SelectionRange.Start.ToString("dd/MM/yyyy");

                        dataCommand.Parameters.AddWithValue("@data", Date);
                        dataCommand.Parameters.AddWithValue("@idT", Program.transport.ID);
                        dataCommand.Parameters.AddWithValue("@idC", Program.cazare.ID);
                        dataCommand.Parameters.AddWithValue("@idAc", Program.activitate.ID);
                        dataCommand.Parameters.AddWithValue("@nume_client", Program.myObj.Name);


                        dataConnection.Open();
                        dataCommand.ExecuteNonQuery();

                        dataConnection.Close();
                        MessageBox.Show("Procesarea este trimisa. \n" +
                           "Veti primi email si veti fi contactat pentru a vi se vor oferi cele mai bune preturi ");


                    

                    }
                }

            } else if(isCazare && isTransport)
            {
                using (SqlConnection dataConnection = new SqlConnection(Program.connetionString))
                {

                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {

                        dataCommand.CommandText = "INSERT INTO rezervare(data_inceput,id_t,id_c,nume_client) values(" +
                                                          "@data,@idT,@idC,@nume_client)";
                        String Date = monthCalendar2.SelectionRange.Start.ToString("dd/MM/yyyy");

                        dataCommand.Parameters.AddWithValue("@data", Date);
                        dataCommand.Parameters.AddWithValue("@idT", Program.transport.ID);
                        dataCommand.Parameters.AddWithValue("@idC", Program.cazare.ID);
                        dataCommand.Parameters.AddWithValue("@nume_client", Program.myObj.Name);



                        dataConnection.Open();
                        dataCommand.ExecuteNonQuery();

                        dataConnection.Close();
                        MessageBox.Show("Procesarea este trimisa. \n" +
                            "Veti primi email si veti fi contactat pentru a vi se vor oferi cele mai bune preturi ");

                    }
                }
            }
            else if (isCazare)
            {
                using (SqlConnection dataConnection = new SqlConnection(Program.connetionString))
                {

                    using (SqlCommand dataCommand = dataConnection.CreateCommand())
                    {

                        dataCommand.CommandText = "INSERT INTO rezervare(data_inceput,id_c,nume_client) values(" +
                                                          "@data,@idC,@nume_client)";
                        String Date = monthCalendar2.SelectionRange.Start.ToString("dd/MM/yyyy");

                        dataCommand.Parameters.AddWithValue("@data", Date);
                      
                        dataCommand.Parameters.AddWithValue("@idC", Program.cazare.ID);
                        dataCommand.Parameters.AddWithValue("@nume_client", Program.myObj.Name);



                        dataConnection.Open();
                        dataCommand.ExecuteNonQuery();

                        dataConnection.Close();
                        MessageBox.Show("Procesarea este trimisa. \n" +
                            "Veti primi email si veti fi contactat pentru a vi se vor oferi cele mai bune preturi ");

                    }
                }
            }

            //start EMAIL
            try
            {
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 587;
                clientDetails.Host = "smtp.gmail.com";
                clientDetails.EnableSsl = true;

                //clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new System.Net.NetworkCredential("vulpeloredanageorgiana@gmail.com", "loredana99");

                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress("vulpeloredanageorgiana@gmail.com");
                mailDetails.To.Add("crsdm24@gmail.com");
                mailDetails.To.Add("vulpeloredanageorgiana@gmail.com");
                mailDetails.Subject = "Rezervarea e aproape sa se termine !";
                mailDetails.IsBodyHtml = false;
                mailDetails.Body = "Sumarul rezervarii dvs: \n" +richTextBox1.Text;

                clientDetails.Send(mailDetails);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //end EMAIL
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
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
