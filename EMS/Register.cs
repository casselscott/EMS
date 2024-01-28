using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace EMS
{
    public partial class Register_Form : Form


    {
        SqlConnection connect
           = new SqlConnection(@"Data Source=DESKTOP-7IEOM2U\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;Connect Timeout=30");
        public Register_Form()

        {
            InitializeComponent();
        }

        private void register_picturebox_Click(object sender, EventArgs e)
        {

        }

        private void ems_label_Click(object sender, EventArgs e)
        {

        }

        private void register_picturebox_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {

        }

        private void register_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_loginbtn_Click(object sender, EventArgs e)
        {
            Login Loginform = new Login();
            Loginform.Show();
            this.Hide();
        }

        private void register_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            registerpassword_textbox.PasswordChar = register_checkbox.Checked ? '\0' : '*';

        }

        private void registerpassword_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (register_usernametextbox.Text == ""
               || registerpassword_textbox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        // TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @users";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@users", register_usernametextbox.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(register_usernametextbox.Text.Trim() + " is already taken"
                                   , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO users " +
                                    "(username, password, date_register) " +
                                    "VALUES(@username, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", register_usernametextbox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", registerpassword_textbox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login Loginform = new Login();
                                    Loginform.Show();
                                    this.Hide();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }



    }
}
                        
                    
                    