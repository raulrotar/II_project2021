
namespace ProiectII.UserControls
{
    partial class UC_LogisticalChanges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LogisticalChanges));
            this.panel1 = new System.Windows.Forms.Panel();
            this.helloLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_DeleteRecord = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.comboBox_SearchBy = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.panel_Price = new System.Windows.Forms.Panel();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.picBox_Price = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_UpdateRecord = new System.Windows.Forms.Button();
            this.btn_InsertRecord = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.helloLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1630, 150);
            this.panel1.TabIndex = 0;
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold);
            this.helloLabel.ForeColor = System.Drawing.Color.White;
            this.helloLabel.Location = new System.Drawing.Point(23, 52);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(122, 37);
            this.helloLabel.TabIndex = 23;
            this.helloLabel.Text = "HELLO,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(623, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Logistical Changes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(765, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 1);
            this.panel2.TabIndex = 21;
            // 
            // btn_DeleteRecord
            // 
            this.btn_DeleteRecord.BackColor = System.Drawing.Color.Brown;
            this.btn_DeleteRecord.FlatAppearance.BorderSize = 0;
            this.btn_DeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteRecord.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteRecord.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteRecord.Location = new System.Drawing.Point(153, 865);
            this.btn_DeleteRecord.Name = "btn_DeleteRecord";
            this.btn_DeleteRecord.Size = new System.Drawing.Size(235, 74);
            this.btn_DeleteRecord.TabIndex = 20;
            this.btn_DeleteRecord.Text = "Delete Record";
            this.btn_DeleteRecord.UseVisualStyleBackColor = false;
            this.btn_DeleteRecord.Click += new System.EventHandler(this.btn_DeleteRecord_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1325, 437);
            this.dataGridView1.TabIndex = 19;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1242, 194);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(229, 71);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_Search.Location = new System.Drawing.Point(765, 220);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(376, 28);
            this.txtBox_Search.TabIndex = 17;
            this.txtBox_Search.Text = "Search Here";
            this.txtBox_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Search.Click += new System.EventHandler(this.SearchBy_Click);
            this.txtBox_Search.TextChanged += new System.EventHandler(this.Search_TxtChanged);
            this.txtBox_Search.Leave += new System.EventHandler(this.SearchBy_Leave);
            // 
            // comboBox_SearchBy
            // 
            this.comboBox_SearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SearchBy.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SearchBy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_SearchBy.FormattingEnabled = true;
            this.comboBox_SearchBy.Items.AddRange(new object[] {
            "Diagnostic",
            "Dental Work",
            "Treatment"});
            this.comboBox_SearchBy.Location = new System.Drawing.Point(354, 211);
            this.comboBox_SearchBy.Name = "comboBox_SearchBy";
            this.comboBox_SearchBy.Size = new System.Drawing.Size(310, 38);
            this.comboBox_SearchBy.TabIndex = 16;
            this.comboBox_SearchBy.SelectedIndexChanged += new System.EventHandler(this.comboBox_SearchBy_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(153, 373);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1325, 437);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Select_All);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(151, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Choose Feature:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(243, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 1);
            this.panel3.TabIndex = 32;
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Name.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_Name.Location = new System.Drawing.Point(243, 301);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(376, 28);
            this.txtBox_Name.TabIndex = 31;
            this.txtBox_Name.Text = "Name";
            this.txtBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Name.Click += new System.EventHandler(this.Name_Click);
            this.txtBox_Name.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // panel_Price
            // 
            this.panel_Price.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_Price.Location = new System.Drawing.Point(836, 335);
            this.panel_Price.Name = "panel_Price";
            this.panel_Price.Size = new System.Drawing.Size(376, 1);
            this.panel_Price.TabIndex = 34;
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Price.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Price.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_Price.Location = new System.Drawing.Point(836, 301);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(376, 28);
            this.txtBox_Price.TabIndex = 33;
            this.txtBox_Price.Text = "Price";
            this.txtBox_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Price.Click += new System.EventHandler(this.Price_Click);
            this.txtBox_Price.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // picBox_Price
            // 
            this.picBox_Price.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Price.Image")));
            this.picBox_Price.Location = new System.Drawing.Point(780, 286);
            this.picBox_Price.Name = "picBox_Price";
            this.picBox_Price.Size = new System.Drawing.Size(50, 50);
            this.picBox_Price.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_Price.TabIndex = 35;
            this.picBox_Price.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // btn_UpdateRecord
            // 
            this.btn_UpdateRecord.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_UpdateRecord.FlatAppearance.BorderSize = 0;
            this.btn_UpdateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateRecord.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateRecord.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateRecord.Location = new System.Drawing.Point(698, 865);
            this.btn_UpdateRecord.Name = "btn_UpdateRecord";
            this.btn_UpdateRecord.Size = new System.Drawing.Size(235, 74);
            this.btn_UpdateRecord.TabIndex = 37;
            this.btn_UpdateRecord.Text = "Update Record";
            this.btn_UpdateRecord.UseVisualStyleBackColor = false;
            this.btn_UpdateRecord.Click += new System.EventHandler(this.btn_UpdateRecord_Click);
            // 
            // btn_InsertRecord
            // 
            this.btn_InsertRecord.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_InsertRecord.FlatAppearance.BorderSize = 0;
            this.btn_InsertRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsertRecord.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertRecord.ForeColor = System.Drawing.Color.White;
            this.btn_InsertRecord.Location = new System.Drawing.Point(1243, 865);
            this.btn_InsertRecord.Name = "btn_InsertRecord";
            this.btn_InsertRecord.Size = new System.Drawing.Size(235, 74);
            this.btn_InsertRecord.TabIndex = 38;
            this.btn_InsertRecord.Text = "Insert Record";
            this.btn_InsertRecord.UseVisualStyleBackColor = false;
            this.btn_InsertRecord.Click += new System.EventHandler(this.btn_InsertRecord_Click);
            // 
            // UC_LogisticalChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_InsertRecord);
            this.Controls.Add(this.btn_UpdateRecord);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBox_Price);
            this.Controls.Add(this.panel_Price);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_DeleteRecord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.comboBox_SearchBy);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_LogisticalChanges";
            this.Size = new System.Drawing.Size(1630, 1000);
            this.Load += new System.EventHandler(this.UC_LogisticalChanges_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_DeleteRecord;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.ComboBox comboBox_SearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Panel panel_Price;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.PictureBox picBox_Price;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_UpdateRecord;
        private System.Windows.Forms.Button btn_InsertRecord;
        private System.Windows.Forms.Label helloLabel;
    }
}
