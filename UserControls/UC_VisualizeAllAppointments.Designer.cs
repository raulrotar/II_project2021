
namespace ProiectII.UserControls
{
    partial class UC_VisualizeAllAppointments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_SearchBy = new System.Windows.Forms.ComboBox();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ClearSearchFields = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1630, 150);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(607, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualize All Appointments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(223, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search By:";
            // 
            // comboBox_SearchBy
            // 
            this.comboBox_SearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SearchBy.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SearchBy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_SearchBy.FormattingEnabled = true;
            this.comboBox_SearchBy.Items.AddRange(new object[] {
            "Day",
            "Patient Name",
            "Month",
            "Year"});
            this.comboBox_SearchBy.Location = new System.Drawing.Point(362, 211);
            this.comboBox_SearchBy.Name = "comboBox_SearchBy";
            this.comboBox_SearchBy.Size = new System.Drawing.Size(310, 38);
            this.comboBox_SearchBy.TabIndex = 2;
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_Search.Location = new System.Drawing.Point(782, 214);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(342, 28);
            this.txtBox_Search.TabIndex = 3;
            this.txtBox_Search.Text = "Search Here";
            this.txtBox_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Search.Click += new System.EventHandler(this.VAA_Click);
            this.txtBox_Search.TextChanged += new System.EventHandler(this.VAA_TextChanged);
            this.txtBox_Search.Enter += new System.EventHandler(this.VAA_Enter);
            this.txtBox_Search.Leave += new System.EventHandler(this.VAA_Leave);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1203, 194);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(229, 71);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(165, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1325, 495);
            this.dataGridView1.TabIndex = 5;
            // 
            // btn_ClearSearchFields
            // 
            this.btn_ClearSearchFields.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_ClearSearchFields.FlatAppearance.BorderSize = 0;
            this.btn_ClearSearchFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearSearchFields.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearSearchFields.ForeColor = System.Drawing.Color.White;
            this.btn_ClearSearchFields.Location = new System.Drawing.Point(667, 898);
            this.btn_ClearSearchFields.Name = "btn_ClearSearchFields";
            this.btn_ClearSearchFields.Size = new System.Drawing.Size(267, 91);
            this.btn_ClearSearchFields.TabIndex = 6;
            this.btn_ClearSearchFields.Text = "Clear Fields";
            this.btn_ClearSearchFields.UseVisualStyleBackColor = false;
            this.btn_ClearSearchFields.Click += new System.EventHandler(this.btn_ClearSearchFields_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(782, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 1);
            this.panel2.TabIndex = 7;
            // 
            // UC_VisualizeAllAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_ClearSearchFields);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.comboBox_SearchBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_VisualizeAllAppointments";
            this.Size = new System.Drawing.Size(1630, 1000);
            this.Load += new System.EventHandler(this.UC_VisualizeAllAppointments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_SearchBy;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ClearSearchFields;
        private System.Windows.Forms.Panel panel2;
    }
}
