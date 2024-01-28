namespace EMS
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeid_textbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fullname_textbox = new System.Windows.Forms.TextBox();
            this.gender_textbox = new System.Windows.Forms.ComboBox();
            this.upload_picturebox = new System.Windows.Forms.PictureBox();
            this.import_photo = new System.Windows.Forms.Button();
            this.addemployee_btn = new System.Windows.Forms.Button();
            this.updatemployee_btn = new System.Windows.Forms.Button();
            this.deletemployee_btn = new System.Windows.Forms.Button();
            this.clearemployee = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.phonenumber_textbox = new System.Windows.Forms.TextBox();
            this.position_textbox = new System.Windows.Forms.ComboBox();
            this.status_textbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upload_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(26, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.Orange;
            this.dataGridView2.Location = new System.Drawing.Point(26, 290);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(732, 661);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee\'s Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(381, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // employeeid_textbox
            // 
            this.employeeid_textbox.Location = new System.Drawing.Point(144, 356);
            this.employeeid_textbox.Multiline = true;
            this.employeeid_textbox.Name = "employeeid_textbox";
            this.employeeid_textbox.Size = new System.Drawing.Size(159, 33);
            this.employeeid_textbox.TabIndex = 6;
            this.employeeid_textbox.TextChanged += new System.EventHandler(this.employeeid_textbox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fullname_textbox
            // 
            this.fullname_textbox.Location = new System.Drawing.Point(144, 416);
            this.fullname_textbox.Multiline = true;
            this.fullname_textbox.Name = "fullname_textbox";
            this.fullname_textbox.Size = new System.Drawing.Size(159, 33);
            this.fullname_textbox.TabIndex = 8;
            this.fullname_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gender_textbox
            // 
            this.gender_textbox.FormattingEnabled = true;
            this.gender_textbox.Items.AddRange(new object[] {
            "Male",
            "",
            "Female",
            "",
            "Others"});
            this.gender_textbox.Location = new System.Drawing.Point(456, 357);
            this.gender_textbox.Name = "gender_textbox";
            this.gender_textbox.Size = new System.Drawing.Size(131, 21);
            this.gender_textbox.TabIndex = 9;
            // 
            // upload_picturebox
            // 
            this.upload_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upload_picturebox.Location = new System.Drawing.Point(617, 308);
            this.upload_picturebox.Name = "upload_picturebox";
            this.upload_picturebox.Size = new System.Drawing.Size(125, 141);
            this.upload_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upload_picturebox.TabIndex = 10;
            this.upload_picturebox.TabStop = false;
            this.upload_picturebox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // import_photo
            // 
            this.import_photo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.import_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_photo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.import_photo.Location = new System.Drawing.Point(634, 455);
            this.import_photo.Name = "import_photo";
            this.import_photo.Size = new System.Drawing.Size(95, 46);
            this.import_photo.TabIndex = 11;
            this.import_photo.Text = "Upload Photo";
            this.import_photo.UseVisualStyleBackColor = false;
            this.import_photo.Click += new System.EventHandler(this.import_photo_Click);
            // 
            // addemployee_btn
            // 
            this.addemployee_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.addemployee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addemployee_btn.Location = new System.Drawing.Point(79, 566);
            this.addemployee_btn.Name = "addemployee_btn";
            this.addemployee_btn.Size = new System.Drawing.Size(95, 37);
            this.addemployee_btn.TabIndex = 12;
            this.addemployee_btn.Text = "Add";
            this.addemployee_btn.UseVisualStyleBackColor = false;
            this.addemployee_btn.Click += new System.EventHandler(this.addemployee_btn_Click);
            // 
            // updatemployee_btn
            // 
            this.updatemployee_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.updatemployee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatemployee_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatemployee_btn.Location = new System.Drawing.Point(245, 566);
            this.updatemployee_btn.Name = "updatemployee_btn";
            this.updatemployee_btn.Size = new System.Drawing.Size(95, 37);
            this.updatemployee_btn.TabIndex = 13;
            this.updatemployee_btn.Text = "Update";
            this.updatemployee_btn.UseVisualStyleBackColor = false;
            this.updatemployee_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // deletemployee_btn
            // 
            this.deletemployee_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.deletemployee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletemployee_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletemployee_btn.Location = new System.Drawing.Point(403, 566);
            this.deletemployee_btn.Name = "deletemployee_btn";
            this.deletemployee_btn.Size = new System.Drawing.Size(97, 37);
            this.deletemployee_btn.TabIndex = 14;
            this.deletemployee_btn.Text = "Delete";
            this.deletemployee_btn.UseVisualStyleBackColor = false;
            // 
            // clearemployee
            // 
            this.clearemployee.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.clearemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearemployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearemployee.Location = new System.Drawing.Point(557, 566);
            this.clearemployee.Name = "clearemployee";
            this.clearemployee.Size = new System.Drawing.Size(91, 37);
            this.clearemployee.TabIndex = 15;
            this.clearemployee.Text = "Clear";
            this.clearemployee.UseVisualStyleBackColor = false;
            this.clearemployee.Click += new System.EventHandler(this.clearemployee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phone Number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // phonenumber_textbox
            // 
            this.phonenumber_textbox.Location = new System.Drawing.Point(144, 482);
            this.phonenumber_textbox.Multiline = true;
            this.phonenumber_textbox.Name = "phonenumber_textbox";
            this.phonenumber_textbox.Size = new System.Drawing.Size(159, 33);
            this.phonenumber_textbox.TabIndex = 17;
            this.phonenumber_textbox.TextChanged += new System.EventHandler(this.phonenumber_textbox_TextChanged);
            // 
            // position_textbox
            // 
            this.position_textbox.FormattingEnabled = true;
            this.position_textbox.Items.AddRange(new object[] {
            "Business Analyst",
            "Software Developer",
            "Database Administrator",
            "UX/UI Designer",
            "Project Manager",
            "HR Manager",
            "Cheif Technology Officer",
            "Head of Operations"});
            this.position_textbox.Location = new System.Drawing.Point(456, 427);
            this.position_textbox.Name = "position_textbox";
            this.position_textbox.Size = new System.Drawing.Size(131, 21);
            this.position_textbox.TabIndex = 18;
            // 
            // status_textbox
            // 
            this.status_textbox.FormattingEnabled = true;
            this.status_textbox.Items.AddRange(new object[] {
            "Active",
            "",
            "Inactive"});
            this.status_textbox.Location = new System.Drawing.Point(456, 496);
            this.status_textbox.Name = "status_textbox";
            this.status_textbox.Size = new System.Drawing.Size(131, 21);
            this.status_textbox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(381, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Orange;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(381, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "status";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.status_textbox);
            this.Controls.Add(this.position_textbox);
            this.Controls.Add(this.phonenumber_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearemployee);
            this.Controls.Add(this.deletemployee_btn);
            this.Controls.Add(this.updatemployee_btn);
            this.Controls.Add(this.addemployee_btn);
            this.Controls.Add(this.import_photo);
            this.Controls.Add(this.upload_picturebox);
            this.Controls.Add(this.gender_textbox);
            this.Controls.Add(this.fullname_textbox);
            this.Controls.Add(this.employeeid_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(782, 659);
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upload_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeeid_textbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox fullname_textbox;
        private System.Windows.Forms.ComboBox gender_textbox;
        private System.Windows.Forms.PictureBox upload_picturebox;
        private System.Windows.Forms.Button import_photo;
        private System.Windows.Forms.Button addemployee_btn;
        private System.Windows.Forms.Button updatemployee_btn;
        private System.Windows.Forms.Button deletemployee_btn;
        private System.Windows.Forms.Button clearemployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phonenumber_textbox;
        private System.Windows.Forms.ComboBox position_textbox;
        private System.Windows.Forms.ComboBox status_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
