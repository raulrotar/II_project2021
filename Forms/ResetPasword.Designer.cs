
namespace ProiectII.Forms
{
    partial class ResetPasword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_InsertEmail = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.txtBox_SCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_resetFields = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Insert email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Insert Security Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm New Password:";
            // 
            // txtBox_InsertEmail
            // 
            this.txtBox_InsertEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_InsertEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_InsertEmail.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_InsertEmail.Location = new System.Drawing.Point(159, 49);
            this.txtBox_InsertEmail.Multiline = true;
            this.txtBox_InsertEmail.Name = "txtBox_InsertEmail";
            this.txtBox_InsertEmail.Size = new System.Drawing.Size(301, 25);
            this.txtBox_InsertEmail.TabIndex = 18;
            this.txtBox_InsertEmail.Text = "someone@example.com";
            this.txtBox_InsertEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IE_Click);
            this.txtBox_InsertEmail.TextChanged += new System.EventHandler(this.txtBox_InsertEmail_TextChanged);
            this.txtBox_InsertEmail.Enter += new System.EventHandler(this.IE_Enter);
            this.txtBox_InsertEmail.Leave += new System.EventHandler(this.IE_Leave);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel.Location = new System.Drawing.Point(159, 74);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(304, 1);
            this.panel.TabIndex = 16;
            // 
            // txtBox_SCode
            // 
            this.txtBox_SCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_SCode.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_SCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_SCode.Location = new System.Drawing.Point(236, 118);
            this.txtBox_SCode.Multiline = true;
            this.txtBox_SCode.Name = "txtBox_SCode";
            this.txtBox_SCode.Size = new System.Drawing.Size(181, 25);
            this.txtBox_SCode.TabIndex = 21;
            this.txtBox_SCode.Text = "Security Code";
            this.txtBox_SCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SC_Click);
            this.txtBox_SCode.Enter += new System.EventHandler(this.SC_Enter);
            this.txtBox_SCode.Leave += new System.EventHandler(this.SQ_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(236, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 1);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(456, 191);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Password.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_Password.Location = new System.Drawing.Point(181, 196);
            this.txtBox_Password.Multiline = true;
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(250, 25);
            this.txtBox_Password.TabIndex = 23;
            this.txtBox_Password.Text = "Password";
            this.txtBox_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NP_Click);
            this.txtBox_Password.Enter += new System.EventHandler(this.NP_Enter);
            this.txtBox_Password.Leave += new System.EventHandler(this.NP_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(181, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBox_ConfirmPassword
            // 
            this.txtBox_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_ConfirmPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ConfirmPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_ConfirmPassword.Location = new System.Drawing.Point(266, 268);
            this.txtBox_ConfirmPassword.Multiline = true;
            this.txtBox_ConfirmPassword.Name = "txtBox_ConfirmPassword";
            this.txtBox_ConfirmPassword.Size = new System.Drawing.Size(257, 25);
            this.txtBox_ConfirmPassword.TabIndex = 26;
            this.txtBox_ConfirmPassword.Text = "Confirm Password";
            this.txtBox_ConfirmPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CP_Click);
            this.txtBox_ConfirmPassword.Enter += new System.EventHandler(this.CP_Enter);
            this.txtBox_ConfirmPassword.Leave += new System.EventHandler(this.CP_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(266, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 1);
            this.panel3.TabIndex = 25;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.FlatAppearance.BorderSize = 2;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Close.Location = new System.Drawing.Point(77, 374);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(143, 67);
            this.btn_Close.TabIndex = 28;
            this.btn_Close.Text = "Exit";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_resetFields
            // 
            this.btn_resetFields.FlatAppearance.BorderSize = 2;
            this.btn_resetFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_resetFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resetFields.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetFields.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_resetFields.Location = new System.Drawing.Point(343, 374);
            this.btn_resetFields.Name = "btn_resetFields";
            this.btn_resetFields.Size = new System.Drawing.Size(143, 67);
            this.btn_resetFields.TabIndex = 30;
            this.btn_resetFields.Text = "Reset Fields";
            this.btn_resetFields.UseVisualStyleBackColor = true;
            this.btn_resetFields.Click += new System.EventHandler(this.btn_resetFields_Click_1);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 2;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Location = new System.Drawing.Point(595, 375);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(143, 67);
            this.btn_Save.TabIndex = 31;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ResetPasword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_resetFields);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBox_ConfirmPassword);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBox_SCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBox_InsertEmail);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResetPasword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ResetPasword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_InsertEmail;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtBox_SCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtBox_ConfirmPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_resetFields;
        private System.Windows.Forms.Button btn_Save;
    }
}