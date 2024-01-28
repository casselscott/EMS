namespace EMS
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iactive_label = new System.Windows.Forms.Label();
            this.active_label = new System.Windows.Forms.Label();
            this.nunmber_total = new System.Windows.Forms.Label();
            this.active_picturebox = new System.Windows.Forms.PictureBox();
            this.inactive_employees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.total_picturebox = new System.Windows.Forms.PictureBox();
            this.dataGridView_inactiveemployees = new System.Windows.Forms.DataGridView();
            this.dataGridView_activeemployee = new System.Windows.Forms.DataGridView();
            this.dataGridView_totalemployee = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.active_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inactiveemployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_activeemployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_totalemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.iactive_label);
            this.panel1.Controls.Add(this.active_label);
            this.panel1.Controls.Add(this.nunmber_total);
            this.panel1.Controls.Add(this.active_picturebox);
            this.panel1.Controls.Add(this.inactive_employees);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.total_picturebox);
            this.panel1.Controls.Add(this.dataGridView_inactiveemployees);
            this.panel1.Controls.Add(this.dataGridView_activeemployee);
            this.panel1.Controls.Add(this.dataGridView_totalemployee);
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 205);
            this.panel1.TabIndex = 0;
            // 
            // iactive_label
            // 
            this.iactive_label.AutoSize = true;
            this.iactive_label.BackColor = System.Drawing.Color.Orange;
            this.iactive_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iactive_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iactive_label.Location = new System.Drawing.Point(689, 57);
            this.iactive_label.Name = "iactive_label";
            this.iactive_label.Size = new System.Drawing.Size(25, 25);
            this.iactive_label.TabIndex = 12;
            this.iactive_label.Text = "0";
            this.iactive_label.Click += new System.EventHandler(this.iactive_label_Click);
            // 
            // active_label
            // 
            this.active_label.AutoSize = true;
            this.active_label.BackColor = System.Drawing.Color.Orange;
            this.active_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.active_label.Location = new System.Drawing.Point(428, 57);
            this.active_label.Name = "active_label";
            this.active_label.Size = new System.Drawing.Size(25, 25);
            this.active_label.TabIndex = 11;
            this.active_label.Text = "0";
            this.active_label.Click += new System.EventHandler(this.active_label_Click);
            // 
            // nunmber_total
            // 
            this.nunmber_total.AutoSize = true;
            this.nunmber_total.BackColor = System.Drawing.Color.Orange;
            this.nunmber_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nunmber_total.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nunmber_total.Location = new System.Drawing.Point(168, 57);
            this.nunmber_total.Name = "nunmber_total";
            this.nunmber_total.Size = new System.Drawing.Size(25, 25);
            this.nunmber_total.TabIndex = 10;
            this.nunmber_total.Text = "0";
            // 
            // active_picturebox
            // 
            this.active_picturebox.BackColor = System.Drawing.Color.Black;
            this.active_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("active_picturebox.Image")));
            this.active_picturebox.Location = new System.Drawing.Point(301, 57);
            this.active_picturebox.Name = "active_picturebox";
            this.active_picturebox.Size = new System.Drawing.Size(80, 85);
            this.active_picturebox.TabIndex = 9;
            this.active_picturebox.TabStop = false;
            this.active_picturebox.Click += new System.EventHandler(this.active_picturebox_Click);
            // 
            // inactive_employees
            // 
            this.inactive_employees.AutoSize = true;
            this.inactive_employees.BackColor = System.Drawing.Color.Orange;
            this.inactive_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactive_employees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inactive_employees.Location = new System.Drawing.Point(558, 139);
            this.inactive_employees.Name = "inactive_employees";
            this.inactive_employees.Size = new System.Drawing.Size(134, 15);
            this.inactive_employees.TabIndex = 8;
            this.inactive_employees.Text = "Inactive  Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(298, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Active Employees";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Employees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(561, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 88);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // total_picturebox
            // 
            this.total_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("total_picturebox.Image")));
            this.total_picturebox.Location = new System.Drawing.Point(42, 57);
            this.total_picturebox.Name = "total_picturebox";
            this.total_picturebox.Size = new System.Drawing.Size(76, 79);
            this.total_picturebox.TabIndex = 3;
            this.total_picturebox.TabStop = false;
            this.total_picturebox.Click += new System.EventHandler(this.total_picturebox_Click);
            // 
            // dataGridView_inactiveemployees
            // 
            this.dataGridView_inactiveemployees.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView_inactiveemployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_inactiveemployees.GridColor = System.Drawing.Color.Orange;
            this.dataGridView_inactiveemployees.Location = new System.Drawing.Point(552, 29);
            this.dataGridView_inactiveemployees.Name = "dataGridView_inactiveemployees";
            this.dataGridView_inactiveemployees.Size = new System.Drawing.Size(200, 137);
            this.dataGridView_inactiveemployees.TabIndex = 2;
            this.dataGridView_inactiveemployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_inactiveemployees_CellContentClick);
            // 
            // dataGridView_activeemployee
            // 
            this.dataGridView_activeemployee.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView_activeemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_activeemployee.Location = new System.Drawing.Point(291, 29);
            this.dataGridView_activeemployee.Name = "dataGridView_activeemployee";
            this.dataGridView_activeemployee.Size = new System.Drawing.Size(200, 137);
            this.dataGridView_activeemployee.TabIndex = 1;
            // 
            // dataGridView_totalemployee
            // 
            this.dataGridView_totalemployee.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView_totalemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_totalemployee.Location = new System.Drawing.Point(31, 29);
            this.dataGridView_totalemployee.Name = "dataGridView_totalemployee";
            this.dataGridView_totalemployee.Size = new System.Drawing.Size(200, 137);
            this.dataGridView_totalemployee.TabIndex = 0;
            this.dataGridView_totalemployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_totalemployee_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(25, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 382);
            this.panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(784, 661);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.active_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inactiveemployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_activeemployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_totalemployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox total_picturebox;
        private System.Windows.Forms.DataGridView dataGridView_inactiveemployees;
        private System.Windows.Forms.DataGridView dataGridView_activeemployee;
        private System.Windows.Forms.DataGridView dataGridView_totalemployee;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inactive_employees;
        private System.Windows.Forms.PictureBox active_picturebox;
        private System.Windows.Forms.Label nunmber_total;
        private System.Windows.Forms.Label iactive_label;
        private System.Windows.Forms.Label active_label;
    }
}
