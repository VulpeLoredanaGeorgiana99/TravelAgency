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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.ToString() != "" && textBox2.Text.ToString() != "")
            {
                SqlConnection cnn;
               
                cnn = new SqlConnection(Program.connetionString);
                cnn.Open();

                SqlCommand command = new SqlCommand("Select type_user from [USER_LOGIN] where user_name = @user and password_name= @pass", cnn);
                command.Parameters.AddWithValue("@user", textBox1.Text.ToLower());
                command.Parameters.AddWithValue("@pass", textBox2.Text.ToLower());
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}", reader["type_user"]));
                        if (Convert.ToInt32(reader["type_user"]) == 1)  //operator
                        {
                            mainPanel.Controls.Clear();
                            HomeOperation operation = new HomeOperation();
                            operation.TopLevel = false;
                            mainPanel.Controls.Add(operation);
                            operation.FormBorderStyle = FormBorderStyle.None;
                            operation.Dock = DockStyle.Fill;
                            operation.Show();
                        }

                        if (Convert.ToInt32(reader["type_user"]) == 2) //manager
                        {
                            mainPanel.Controls.Clear();
                            HomeManagement management = new HomeManagement();
                            management.TopLevel = false;
                            mainPanel.Controls.Add(management);
                            management.FormBorderStyle = FormBorderStyle.None;
                            management.Dock = DockStyle.Fill;
                            management.Show();
                        } else if(Convert.ToInt32(reader["type_user"]) == 1) //operator
                        {
                            mainPanel.Controls.Clear();
                            HomeOperation homeOperation = new HomeOperation();
                            homeOperation.TopLevel = false;
                            mainPanel.Controls.Add(homeOperation);
                            homeOperation.FormBorderStyle = FormBorderStyle.None;
                            homeOperation.Dock = DockStyle.Fill;
                            homeOperation.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Username sau parola incorecta");
                    }
                }
                cnn.Close();
            }
            else
            {
                MessageBox.Show("Nu s-au introdus toate campurile");
            }
              
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("SSS");
        }
    }
}
