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
    public partial class Login : Form

    {

        SqlConnection connect
           = new SqlConnection(@"Data Source=DESKTOP-7IEOM2U\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registerbtn_Click(object sender, EventArgs e)
        {
            Register_Form regform = new Register_Form();
            regform.Show();
            this.Hide();
        }

        private void loginpassword_checkbox_CheckedChanged(object sender, EventArgs e)
        {

            login_passwordtextbox.PasswordChar = loginpassword_checkbox.Checked ? '\0' : '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_usernametextbox.Text == ""
               || login_passwordtextbox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM users WHERE username = @username " +
                            "AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_usernametextbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_passwordtextbox.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Mainform mForm = new Mainform();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

   


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_passwordtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
