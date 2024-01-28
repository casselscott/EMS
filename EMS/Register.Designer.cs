namespace EMS
{
    partial class Register_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Form));
            this.register_panel = new System.Windows.Forms.Panel();
            this.register_loginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.register_picturebox = new System.Windows.Forms.PictureBox();
            this.ems_label = new System.Windows.Forms.Label();
            this.register_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.register_usernametextbox = new System.Windows.Forms.TextBox();
            this.register_exit = new System.Windows.Forms.Label();
            this.register_password = new System.Windows.Forms.Label();
            this.registerpassword_textbox = new System.Windows.Forms.TextBox();
            this.register_checkbox = new System.Windows.Forms.CheckBox();
            this.register_button = new System.Windows.Forms.Button();
            this.register_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // register_panel
            // 
            this.register_panel.AllowDrop = true;
            this.register_panel.BackColor = System.Drawing.Color.Orange;
            this.register_panel.Controls.Add(this.register_loginbtn);
            this.register_panel.Controls.Add(this.label1);
            this.register_panel.Controls.Add(this.register_picturebox);
            this.register_panel.Controls.Add(this.ems_label);
            this.register_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.register_panel.Location = new System.Drawing.Point(0, 0);
            this.register_panel.Name = "register_panel";
            this.register_panel.Size = new System.Drawing.Size(323, 661);
            this.register_panel.TabIndex = 0;
            // 
            // register_loginbtn
            // 
            this.register_loginbtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.register_loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_loginbtn.ForeColor = System.Drawing.Color.Snow;
            this.register_loginbtn.Location = new System.Drawing.Point(74, 552);
            this.register_loginbtn.Name = "register_loginbtn";
            this.register_loginbtn.Size = new System.Drawing.Size(175, 53);
            this.register_loginbtn.TabIndex = 3;
            this.register_loginbtn.Text = "Login";
            this.register_loginbtn.UseVisualStyleBackColor = false;
            this.register_loginbtn.Click += new System.EventHandler(this.register_loginbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(61, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Already have an Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // register_picturebox
            // 
            this.register_picturebox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.register_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.register_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("register_picturebox.Image")));
            this.register_picturebox.Location = new System.Drawing.Point(48, 62);
            this.register_picturebox.Name = "register_picturebox";
            this.register_picturebox.Size = new System.Drawing.Size(221, 252);
            this.register_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.register_picturebox.TabIndex = 1;
            this.register_picturebox.TabStop = false;
            this.register_picturebox.Visible = false;
            this.register_picturebox.Click += new System.EventHandler(this.register_picturebox_Click_1);
            // 
            // ems_label
            // 
            this.ems_label.AutoSize = true;
            this.ems_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ems_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ems_label.Location = new System.Drawing.Point(16, 343);
            this.ems_label.Name = "ems_label";
            this.ems_label.Size = new System.Drawing.Size(304, 24);
            this.ems_label.TabIndex = 0;
            this.ems_label.Text = "Employee Management System";
            this.ems_label.Click += new System.EventHandler(this.ems_label_Click);
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_label.Location = new System.Drawing.Point(410, 74);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(246, 29);
            this.register_label.TabIndex = 1;
            this.register_label.Text = "Register an Account";
            this.register_label.Click += new System.EventHandler(this.register_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.username_label.Location = new System.Drawing.Point(358, 201);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(105, 24);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username";
            this.username_label.Click += new System.EventHandler(this.username_label_Click);
            // 
            // register_usernametextbox
            // 
            this.register_usernametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_usernametextbox.Location = new System.Drawing.Point(485, 201);
            this.register_usernametextbox.Multiline = true;
            this.register_usernametextbox.Name = "register_usernametextbox";
            this.register_usernametextbox.Size = new System.Drawing.Size(171, 35);
            this.register_usernametextbox.TabIndex = 3;
            // 
            // register_exit
            // 
            this.register_exit.AutoSize = true;
            this.register_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_exit.Location = new System.Drawing.Point(762, 0);
            this.register_exit.Name = "register_exit";
            this.register_exit.Size = new System.Drawing.Size(19, 18);
            this.register_exit.TabIndex = 4;
            this.register_exit.Text = "X";
            this.register_exit.Click += new System.EventHandler(this.register_exit_Click);
            // 
            // register_password
            // 
            this.register_password.AutoSize = true;
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_password.Location = new System.Drawing.Point(358, 320);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(100, 24);
            this.register_password.TabIndex = 5;
            this.register_password.Text = "Password";
            // 
            // registerpassword_textbox
            // 
            this.registerpassword_textbox.Location = new System.Drawing.Point(485, 308);
            this.registerpassword_textbox.Multiline = true;
            this.registerpassword_textbox.Name = "registerpassword_textbox";
            this.registerpassword_textbox.Size = new System.Drawing.Size(171, 36);
            this.registerpassword_textbox.TabIndex = 6;
            this.registerpassword_textbox.TextChanged += new System.EventHandler(this.registerpassword_textbox_TextChanged);
            // 
            // register_checkbox
            // 
            this.register_checkbox.AutoSize = true;
            this.register_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_checkbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_checkbox.Location = new System.Drawing.Point(544, 361);
            this.register_checkbox.Name = "register_checkbox";
            this.register_checkbox.Size = new System.Drawing.Size(112, 17);
            this.register_checkbox.TabIndex = 7;
            this.register_checkbox.Text = "show password";
            this.register_checkbox.UseVisualStyleBackColor = true;
            this.register_checkbox.CheckedChanged += new System.EventHandler(this.register_checkbox_CheckedChanged);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_button.Location = new System.Drawing.Point(474, 463);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(175, 53);
            this.register_button.TabIndex = 8;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // Register_Form
            // 
            this.AccessibleName = "Register";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.register_checkbox);
            this.Controls.Add(this.registerpassword_textbox);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_exit);
            this.Controls.Add(this.register_usernametextbox);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.register_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register_Form";
            this.Text = " Register Form";
            this.register_panel.ResumeLayout(false);
            this.register_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel register_panel;
        private System.Windows.Forms.Label ems_label;
        private System.Windows.Forms.PictureBox register_picturebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_loginbtn;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox register_usernametextbox;
        private System.Windows.Forms.Label register_exit;
        private System.Windows.Forms.Label register_password;
        private System.Windows.Forms.TextBox registerpassword_textbox;
        private System.Windows.Forms.CheckBox register_checkbox;
        private System.Windows.Forms.Button register_button;
    }
}

