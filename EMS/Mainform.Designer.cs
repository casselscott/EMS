namespace EMS
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.header = new System.Windows.Forms.Panel();
            this.main_exit = new System.Windows.Forms.Label();
            this.main_label = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.logout_label = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Button();
            this.addemployee = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employee1 = new EMS.Employee();
            this.salary1 = new EMS.Salary();
            this.dashboard1 = new EMS.Dashboard();
            this.header.SuspendLayout();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Orange;
            this.header.Controls.Add(this.main_exit);
            this.header.Controls.Add(this.main_label);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1169, 44);
            this.header.TabIndex = 0;
            // 
            // main_exit
            // 
            this.main_exit.AutoSize = true;
            this.main_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.main_exit.Location = new System.Drawing.Point(1132, 9);
            this.main_exit.Name = "main_exit";
            this.main_exit.Size = new System.Drawing.Size(25, 24);
            this.main_exit.TabIndex = 1;
            this.main_exit.Text = "X";
            this.main_exit.Click += new System.EventHandler(this.main_exit_Click);
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.main_label.Location = new System.Drawing.Point(12, 9);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(260, 20);
            this.main_label.TabIndex = 0;
            this.main_label.Text = "Employee Management System";
            this.main_label.Click += new System.EventHandler(this.main_label_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Orange;
            this.sidebar.Controls.Add(this.logout_btn);
            this.sidebar.Controls.Add(this.logout_label);
            this.sidebar.Controls.Add(this.salary);
            this.sidebar.Controls.Add(this.addemployee);
            this.sidebar.Controls.Add(this.welcome);
            this.sidebar.Controls.Add(this.dashboard_btn);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 44);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(320, 717);
            this.sidebar.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.Location = new System.Drawing.Point(40, 550);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(49, 42);
            this.logout_btn.TabIndex = 7;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // logout_label
            // 
            this.logout_label.AutoSize = true;
            this.logout_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_label.Location = new System.Drawing.Point(37, 595);
            this.logout_label.Name = "logout_label";
            this.logout_label.Size = new System.Drawing.Size(52, 13);
            this.logout_label.TabIndex = 6;
            this.logout_label.Text = "Log Out";
            this.logout_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salary.Image = ((System.Drawing.Image)(resources.GetObject("salary.Image")));
            this.salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salary.Location = new System.Drawing.Point(40, 466);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(221, 50);
            this.salary.TabIndex = 4;
            this.salary.Text = "Salary";
            this.salary.UseVisualStyleBackColor = false;
            this.salary.Click += new System.EventHandler(this.salary_Click);
            // 
            // addemployee
            // 
            this.addemployee.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.addemployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addemployee.Image = ((System.Drawing.Image)(resources.GetObject("addemployee.Image")));
            this.addemployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addemployee.Location = new System.Drawing.Point(40, 401);
            this.addemployee.Name = "addemployee";
            this.addemployee.Size = new System.Drawing.Size(221, 50);
            this.addemployee.TabIndex = 3;
            this.addemployee.Text = "ADD EMPLOYEE";
            this.addemployee.UseVisualStyleBackColor = false;
            this.addemployee.Click += new System.EventHandler(this.addemployee_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Snow;
            this.welcome.Location = new System.Drawing.Point(83, 301);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(130, 20);
            this.welcome.TabIndex = 2;
            this.welcome.Text = "Welcome, User";
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboard_btn.Image = ((System.Drawing.Image)(resources.GetObject("dashboard_btn.Image")));
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(40, 334);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(221, 50);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // employee1
            // 
            this.employee1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employee1.Location = new System.Drawing.Point(315, 44);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(854, 717);
            this.employee1.TabIndex = 3;
            this.employee1.Load += new System.EventHandler(this.employee1_Load);
            // 
            // salary1
            // 
            this.salary1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salary1.Location = new System.Drawing.Point(320, 44);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(849, 661);
            this.salary1.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dashboard1.Location = new System.Drawing.Point(315, 44);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(851, 717);
            this.dashboard1.TabIndex = 4;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1169, 761);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.employee1);
            this.Controls.Add(this.salary1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button salary;
        private System.Windows.Forms.Button addemployee;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label main_exit;
        private Salary salary1;
        private Employee employee1;
        private Dashboard dashboard1;
    }
}