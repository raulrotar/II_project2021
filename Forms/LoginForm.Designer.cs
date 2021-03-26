
namespace ProiectII
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginGB = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.txtBox_UserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_NewAcount = new System.Windows.Forms.Button();
            this.btn_ResetPassword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error_Msg = new System.Windows.Forms.TextBox();
            this.loginGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginGB
            // 
            this.loginGB.Controls.Add(this.error_Msg);
            this.loginGB.Controls.Add(this.pictureBox4);
            this.loginGB.Controls.Add(this.txtBox_Password);
            this.loginGB.Controls.Add(this.txtBox_UserName);
            this.loginGB.Controls.Add(this.panel1);
            this.loginGB.Controls.Add(this.pictureBox3);
            this.loginGB.Controls.Add(this.panel);
            this.loginGB.Controls.Add(this.pictureBox2);
            this.loginGB.Controls.Add(this.btn_NewAcount);
            this.loginGB.Controls.Add(this.btn_ResetPassword);
            this.loginGB.Controls.Add(this.label5);
            this.loginGB.Controls.Add(this.label2);
            this.loginGB.Controls.Add(this.btn_Login);
            this.loginGB.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginGB.Location = new System.Drawing.Point(388, 46);
            this.loginGB.Margin = new System.Windows.Forms.Padding(2);
            this.loginGB.Name = "loginGB";
            this.loginGB.Padding = new System.Windows.Forms.Padding(2);
            this.loginGB.Size = new System.Drawing.Size(286, 489);
            this.loginGB.TabIndex = 1;
            this.loginGB.TabStop = false;
            this.loginGB.Text = "Login First";
            this.loginGB.Enter += new System.EventHandler(this.loginGB_Enter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(255, 104);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_Password.Location = new System.Drawing.Point(50, 102);
            this.txtBox_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Password.Multiline = true;
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(202, 24);
            this.txtBox_Password.TabIndex = 16;
            this.txtBox_Password.Text = "Password";
            this.txtBox_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Password_Click);
            this.txtBox_Password.TextChanged += new System.EventHandler(this.txtBox_Password_TextChanged_1);
            this.txtBox_Password.Enter += new System.EventHandler(this.Password_Enter);
            this.txtBox_Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_UserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_UserName.Location = new System.Drawing.Point(50, 37);
            this.txtBox_UserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_UserName.Multiline = true;
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(202, 24);
            this.txtBox_UserName.TabIndex = 15;
            this.txtBox_UserName.Text = "User Name";
            this.txtBox_UserName.Click += new System.EventHandler(this.UserName_Click);
            this.txtBox_UserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserName_Click);
            this.txtBox_UserName.Enter += new System.EventHandler(this.UserName_Enter);
            this.txtBox_UserName.Leave += new System.EventHandler(this.UserName_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(19, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 1);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 102);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel.Location = new System.Drawing.Point(20, 67);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(228, 1);
            this.panel.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btn_NewAcount
            // 
            this.btn_NewAcount.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_NewAcount.FlatAppearance.BorderSize = 0;
            this.btn_NewAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewAcount.ForeColor = System.Drawing.Color.White;
            this.btn_NewAcount.Location = new System.Drawing.Point(19, 414);
            this.btn_NewAcount.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NewAcount.Name = "btn_NewAcount";
            this.btn_NewAcount.Size = new System.Drawing.Size(247, 32);
            this.btn_NewAcount.TabIndex = 10;
            this.btn_NewAcount.Text = "Create New Account";
            this.btn_NewAcount.UseVisualStyleBackColor = false;
            this.btn_NewAcount.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ResetPassword
            // 
            this.btn_ResetPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ResetPassword.FlatAppearance.BorderSize = 0;
            this.btn_ResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetPassword.ForeColor = System.Drawing.Color.White;
            this.btn_ResetPassword.Location = new System.Drawing.Point(19, 311);
            this.btn_ResetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ResetPassword.Name = "btn_ResetPassword";
            this.btn_ResetPassword.Size = new System.Drawing.Size(247, 32);
            this.btn_ResetPassword.TabIndex = 4;
            this.btn_ResetPassword.Text = "Reset Password";
            this.btn_ResetPassword.UseVisualStyleBackColor = false;
            this.btn_ResetPassword.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "New User?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Forgot Password?";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Login.Location = new System.Drawing.Point(20, 201);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(246, 41);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(34, 67);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(261, 162);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert nume grup here";
            // 
            // error_Msg
            // 
            this.error_Msg.BackColor = System.Drawing.Color.White;
            this.error_Msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.error_Msg.ForeColor = System.Drawing.Color.Red;
            this.error_Msg.Location = new System.Drawing.Point(20, 164);
            this.error_Msg.Multiline = true;
            this.error_Msg.Name = "error_Msg";
            this.error_Msg.ReadOnly = true;
            this.error_Msg.Size = new System.Drawing.Size(257, 20);
            this.error_Msg.TabIndex = 18;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.loginGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginGB.ResumeLayout(false);
            this.loginGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox loginGB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NewAcount;
        private System.Windows.Forms.Button btn_ResetPassword;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBox_UserName;
        public System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox error_Msg;
    }
}

