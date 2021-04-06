
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasword));
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
            this.emailComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_InsertEmail
            // 
            this.txtBox_InsertEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_InsertEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_InsertEmail.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_InsertEmail.Location = new System.Drawing.Point(82, 29);
            this.txtBox_InsertEmail.Multiline = true;
            this.txtBox_InsertEmail.Name = "txtBox_InsertEmail";
            this.txtBox_InsertEmail.Size = new System.Drawing.Size(350, 28);
            this.txtBox_InsertEmail.TabIndex = 18;
            this.txtBox_InsertEmail.Text = "Insert Email";
            this.txtBox_InsertEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IE_Click);
            this.txtBox_InsertEmail.Enter += new System.EventHandler(this.IE_Enter);
            this.txtBox_InsertEmail.Leave += new System.EventHandler(this.IE_Leave);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel.Location = new System.Drawing.Point(82, 62);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(350, 1);
            this.panel.TabIndex = 16;
            // 
            // txtBox_SCode
            // 
            this.txtBox_SCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_SCode.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtBox_SCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_SCode.Location = new System.Drawing.Point(85, 109);
            this.txtBox_SCode.Multiline = true;
            this.txtBox_SCode.Name = "txtBox_SCode";
            this.txtBox_SCode.Size = new System.Drawing.Size(347, 25);
            this.txtBox_SCode.TabIndex = 21;
            this.txtBox_SCode.Text = "Security Code";
            this.txtBox_SCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SC_Click);
            this.txtBox_SCode.Enter += new System.EventHandler(this.SC_Enter);
            this.txtBox_SCode.Leave += new System.EventHandler(this.SQ_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(82, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 1);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(456, 199);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Password.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtBox_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_Password.Location = new System.Drawing.Point(82, 199);
            this.txtBox_Password.Multiline = true;
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(350, 25);
            this.txtBox_Password.TabIndex = 23;
            this.txtBox_Password.Text = "New Password";
            this.txtBox_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NP_Click);
            this.txtBox_Password.Enter += new System.EventHandler(this.NP_Enter);
            this.txtBox_Password.Leave += new System.EventHandler(this.NP_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(82, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 1);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBox_ConfirmPassword
            // 
            this.txtBox_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_ConfirmPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtBox_ConfirmPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_ConfirmPassword.Location = new System.Drawing.Point(85, 274);
            this.txtBox_ConfirmPassword.Multiline = true;
            this.txtBox_ConfirmPassword.Name = "txtBox_ConfirmPassword";
            this.txtBox_ConfirmPassword.Size = new System.Drawing.Size(347, 25);
            this.txtBox_ConfirmPassword.TabIndex = 26;
            this.txtBox_ConfirmPassword.Text = "Confirm New Password";
            this.txtBox_ConfirmPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CP_Click);
            this.txtBox_ConfirmPassword.Enter += new System.EventHandler(this.CP_Enter);
            this.txtBox_ConfirmPassword.Leave += new System.EventHandler(this.CP_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(85, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 1);
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
            // emailComboBox
            // 
            this.emailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emailComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailComboBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailComboBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.emailComboBox.FormattingEnabled = true;
            this.emailComboBox.Items.AddRange(new object[] {
            "@yahoo.com",
            "@gmail.com"});
            this.emailComboBox.Location = new System.Drawing.Point(438, 26);
            this.emailComboBox.Name = "emailComboBox";
            this.emailComboBox.Size = new System.Drawing.Size(196, 37);
            this.emailComboBox.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(17, 191);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(17, 264);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(456, 109);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 37;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseClick);
            // 
            // ResetPasword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.emailComboBox);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResetPasword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ResetPasword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ComboBox emailComboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}