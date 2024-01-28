namespace EMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_panel = new System.Windows.Forms.Panel();
            this.login_registerbtn = new System.Windows.Forms.Button();
            this.noaccount_label = new System.Windows.Forms.Label();
            this.logimems_label = new System.Windows.Forms.Label();
            this.login_picturebox = new System.Windows.Forms.PictureBox();
            this.logintoyouraccount_label = new System.Windows.Forms.Label();
            this.login_usernamelabel = new System.Windows.Forms.Label();
            this.login_usernametextbox = new System.Windows.Forms.TextBox();
            this.login_passwordlabel = new System.Windows.Forms.Label();
            this.login_passwordtextbox = new System.Windows.Forms.TextBox();
            this.loginpassword_checkbox = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_exit = new System.Windows.Forms.Label();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.Color.Orange;
            this.login_panel.Controls.Add(this.login_registerbtn);
            this.login_panel.Controls.Add(this.noaccount_label);
            this.login_panel.Controls.Add(this.logimems_label);
            this.login_panel.Controls.Add(this.login_picturebox);
            this.login_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.login_panel.Location = new System.Drawing.Point(0, 0);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(323, 661);
            this.login_panel.TabIndex = 0;
            // 
            // login_registerbtn
            // 
            this.login_registerbtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.login_registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_registerbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_registerbtn.Location = new System.Drawing.Point(68, 559);
            this.login_registerbtn.Name = "login_registerbtn";
            this.login_registerbtn.Size = new System.Drawing.Size(175, 53);
            this.login_registerbtn.TabIndex = 3;
            this.login_registerbtn.Text = "Register";
            this.login_registerbtn.UseVisualStyleBackColor = false;
            this.login_registerbtn.Click += new System.EventHandler(this.login_registerbtn_Click);
            // 
            // noaccount_label
            // 
            this.noaccount_label.AutoSize = true;
            this.noaccount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noaccount_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.noaccount_label.Location = new System.Drawing.Point(53, 518);
            this.noaccount_label.Name = "noaccount_label";
            this.noaccount_label.Size = new System.Drawing.Size(201, 20);
            this.noaccount_label.TabIndex = 2;
            this.noaccount_label.Text = "Don\'t have an Account?";
            // 
            // logimems_label
            // 
            this.logimems_label.AutoSize = true;
            this.logimems_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logimems_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logimems_label.Location = new System.Drawing.Point(12, 348);
            this.logimems_label.Name = "logimems_label";
            this.logimems_label.Size = new System.Drawing.Size(304, 24);
            this.logimems_label.TabIndex = 1;
            this.logimems_label.Text = "Employee Management System";
            this.logimems_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_picturebox
            // 
            this.login_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("login_picturebox.Image")));
            this.login_picturebox.Location = new System.Drawing.Point(44, 66);
            this.login_picturebox.Name = "login_picturebox";
            this.login_picturebox.Size = new System.Drawing.Size(221, 252);
            this.login_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.login_picturebox.TabIndex = 0;
            this.login_picturebox.TabStop = false;
            // 
            // logintoyouraccount_label
            // 
            this.logintoyouraccount_label.AutoSize = true;
            this.logintoyouraccount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintoyouraccount_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logintoyouraccount_label.Location = new System.Drawing.Point(416, 66);
            this.logintoyouraccount_label.Name = "logintoyouraccount_label";
            this.logintoyouraccount_label.Size = new System.Drawing.Size(268, 29);
            this.logintoyouraccount_label.TabIndex = 1;
            this.logintoyouraccount_label.Text = "Login to Your Account";
            // 
            // login_usernamelabel
            // 
            this.login_usernamelabel.AutoSize = true;
            this.login_usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_usernamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_usernamelabel.Location = new System.Drawing.Point(374, 192);
            this.login_usernamelabel.Name = "login_usernamelabel";
            this.login_usernamelabel.Size = new System.Drawing.Size(91, 20);
            this.login_usernamelabel.TabIndex = 2;
            this.login_usernamelabel.Text = "Username";
            // 
            // login_usernametextbox
            // 
            this.login_usernametextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_usernametextbox.Location = new System.Drawing.Point(492, 192);
            this.login_usernametextbox.Multiline = true;
            this.login_usernametextbox.Name = "login_usernametextbox";
            this.login_usernametextbox.Size = new System.Drawing.Size(171, 36);
            this.login_usernametextbox.TabIndex = 3;
            this.login_usernametextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // login_passwordlabel
            // 
            this.login_passwordlabel.AutoSize = true;
            this.login_passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_passwordlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_passwordlabel.Location = new System.Drawing.Point(374, 294);
            this.login_passwordlabel.Name = "login_passwordlabel";
            this.login_passwordlabel.Size = new System.Drawing.Size(100, 24);
            this.login_passwordlabel.TabIndex = 4;
            this.login_passwordlabel.Text = "Password";
            // 
            // login_passwordtextbox
            // 
            this.login_passwordtextbox.Location = new System.Drawing.Point(492, 294);
            this.login_passwordtextbox.Multiline = true;
            this.login_passwordtextbox.Name = "login_passwordtextbox";
            this.login_passwordtextbox.Size = new System.Drawing.Size(171, 36);
            this.login_passwordtextbox.TabIndex = 5;
            this.login_passwordtextbox.TextChanged += new System.EventHandler(this.login_passwordtextbox_TextChanged);
            // 
            // loginpassword_checkbox
            // 
            this.loginpassword_checkbox.AutoSize = true;
            this.loginpassword_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpassword_checkbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginpassword_checkbox.Location = new System.Drawing.Point(551, 336);
            this.loginpassword_checkbox.Name = "loginpassword_checkbox";
            this.loginpassword_checkbox.Size = new System.Drawing.Size(112, 17);
            this.loginpassword_checkbox.TabIndex = 6;
            this.loginpassword_checkbox.Text = "show password";
            this.loginpassword_checkbox.UseVisualStyleBackColor = true;
            this.loginpassword_checkbox.CheckedChanged += new System.EventHandler(this.loginpassword_checkbox_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Snow;
            this.login_btn.Location = new System.Drawing.Point(469, 485);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(175, 53);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_exit
            // 
            this.login_exit.AutoSize = true;
            this.login_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_exit.Location = new System.Drawing.Point(762, 0);
            this.login_exit.Name = "login_exit";
            this.login_exit.Size = new System.Drawing.Size(19, 18);
            this.login_exit.TabIndex = 8;
            this.login_exit.Text = "X";
            this.login_exit.Click += new System.EventHandler(this.login_exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.login_exit);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.loginpassword_checkbox);
            this.Controls.Add(this.login_passwordtextbox);
            this.Controls.Add(this.login_passwordlabel);
            this.Controls.Add(this.login_usernametextbox);
            this.Controls.Add(this.login_usernamelabel);
            this.Controls.Add(this.logintoyouraccount_label);
            this.Controls.Add(this.login_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.PictureBox login_picturebox;
        private System.Windows.Forms.Label logimems_label;
        private System.Windows.Forms.Button login_registerbtn;
        private System.Windows.Forms.Label noaccount_label;
        private System.Windows.Forms.Label logintoyouraccount_label;
        private System.Windows.Forms.Label login_usernamelabel;
        private System.Windows.Forms.TextBox login_usernametextbox;
        private System.Windows.Forms.Label login_passwordlabel;
        private System.Windows.Forms.TextBox login_passwordtextbox;
        private System.Windows.Forms.CheckBox loginpassword_checkbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label login_exit;
    }
}