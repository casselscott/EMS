using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void main_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void main_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
               , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            {
                dashboard1.Visible = true;
                employee1.Visible = false;
                salary1.Visible = false;
            }
        }

        private void addemployee_Click(object sender, EventArgs e)
        {
            employee1.Visible = true;
            dashboard1.Visible = false;
            salary1.Visible = false;
        }

        private void salary_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            employee1.Visible = false;
            salary1.Visible = true;
        }

        private void employee1_Load(object sender, EventArgs e)
        {

        }
    }
}
