using EmployeeManagementSystem;
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
using System.Runtime.Remoting.Contexts;
using System.IO;

namespace EMS
{
    public partial class Employee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7IEOM2U\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;Connect Timeout=30;");
        public Employee()
        {
            InitializeComponent();

            // TO DISPLAY THE DATA FROM DATABASE TO YOUR DATA GRID VIEW
            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }

        private void employeeid_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addemployee_btn_Click(object sender, EventArgs e)
        {
            if (employeeid_textbox.Text == ""
                || fullname_textbox.Text == ""
                || gender_textbox.Text == ""
                || phonenumber_textbox.Text == ""
                || position_textbox.Text == ""
                || gender_textbox.Text == ""
                || status_textbox.Text == ""
                || import_photo.Image == null)
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
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", employeeid_textbox.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(employeeid_textbox.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees " +
                                    "(employee_id, full_name, gender, contact_number" +
                                    ", position, image, salary, insert_date, status) " +
                                    "VALUES(@employeeID, @full_Name, @gender, @contact_number" +
                                    ", @position, @image, @salary, @insert_date, @status)";


                                string path = Path.Combine(@"C:\Users\casse\Desktop\EMS\EMS\Directory\"
                                    + employeeid_textbox.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(upload_picturebox.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", employeeid_textbox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@full_name", fullname_textbox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", gender_textbox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contact_number", phonenumber_textbox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", position_textbox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insert_date", today);
                                    cmd.Parameters.AddWithValue("@status", status_textbox.Text.Trim());
                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();

                                    
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



        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void phonenumber_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void import_photo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    upload_picturebox.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                employeeid_textbox.Text = row.Cells[1].Value.ToString();
                fullname_textbox.Text = row.Cells[2].Value.ToString();
                gender_textbox.Text = row.Cells[3].Value.ToString();
                phonenumber_textbox.Text = row.Cells[4].Value.ToString();
                position_textbox.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    import_photo.Image = Image.FromFile(imagePath);
                }
                else
                {
                    import_photo.Image = null;
                }

                status_textbox.Text = row.Cells[8].Value.ToString();
            }
        }

        public void clearFields()
        {
            employeeid_textbox.Text = "";
            fullname_textbox.Text = "";
            gender_textbox.SelectedIndex = -1;
            phonenumber_textbox.Text = "";
            position_textbox.SelectedIndex = -1;
            status_textbox.SelectedIndex = -1;
            import_photo.Image = null;
        }

        private void clearemployee_Click(object sender, EventArgs e)
        {
           
        }
    }
    }




