
namespace ProiectII.Forms
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.LeftPannel = new System.Windows.Forms.Panel();
            this.btn_ModificaProgramare = new System.Windows.Forms.Button();
            this.btn_SchimbariLogistice = new System.Windows.Forms.Button();
            this.btn_VizitaCurenta = new System.Windows.Forms.Button();
            this.btn_CautaVizite = new System.Windows.Forms.Button();
            this.btn_ToateProgramarile = new System.Windows.Forms.Button();
            this.btn_CreazaProgramare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Up_Panel = new System.Windows.Forms.Panel();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.LeftPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Up_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPannel
            // 
            this.LeftPannel.BackColor = System.Drawing.Color.DodgerBlue;
            this.LeftPannel.Controls.Add(this.btn_ModificaProgramare);
            this.LeftPannel.Controls.Add(this.btn_SchimbariLogistice);
            this.LeftPannel.Controls.Add(this.btn_VizitaCurenta);
            this.LeftPannel.Controls.Add(this.btn_CautaVizite);
            this.LeftPannel.Controls.Add(this.btn_ToateProgramarile);
            this.LeftPannel.Controls.Add(this.btn_CreazaProgramare);
            this.LeftPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPannel.Location = new System.Drawing.Point(0, 148);
            this.LeftPannel.Name = "LeftPannel";
            this.LeftPannel.Size = new System.Drawing.Size(280, 663);
            this.LeftPannel.TabIndex = 1;
            // 
            // btn_ModificaProgramare
            // 
            this.btn_ModificaProgramare.FlatAppearance.BorderSize = 0;
            this.btn_ModificaProgramare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificaProgramare.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificaProgramare.ForeColor = System.Drawing.Color.White;
            this.btn_ModificaProgramare.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModificaProgramare.Image")));
            this.btn_ModificaProgramare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificaProgramare.Location = new System.Drawing.Point(-1, 423);
            this.btn_ModificaProgramare.Name = "btn_ModificaProgramare";
            this.btn_ModificaProgramare.Size = new System.Drawing.Size(278, 108);
            this.btn_ModificaProgramare.TabIndex = 6;
            this.btn_ModificaProgramare.Text = "     Modify Existing    Appointment";
            this.btn_ModificaProgramare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ModificaProgramare.UseVisualStyleBackColor = true;
            this.btn_ModificaProgramare.Click += new System.EventHandler(this.btn_ModificaProgramare_Click);
            // 
            // btn_SchimbariLogistice
            // 
            this.btn_SchimbariLogistice.FlatAppearance.BorderSize = 0;
            this.btn_SchimbariLogistice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SchimbariLogistice.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SchimbariLogistice.ForeColor = System.Drawing.Color.White;
            this.btn_SchimbariLogistice.Image = ((System.Drawing.Image)(resources.GetObject("btn_SchimbariLogistice.Image")));
            this.btn_SchimbariLogistice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SchimbariLogistice.Location = new System.Drawing.Point(0, 537);
            this.btn_SchimbariLogistice.Name = "btn_SchimbariLogistice";
            this.btn_SchimbariLogistice.Size = new System.Drawing.Size(278, 122);
            this.btn_SchimbariLogistice.TabIndex = 7;
            this.btn_SchimbariLogistice.Text = "     Logistical Changes";
            this.btn_SchimbariLogistice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SchimbariLogistice.UseVisualStyleBackColor = true;
            this.btn_SchimbariLogistice.Click += new System.EventHandler(this.btn_SchimbariLogistice_Click);
            // 
            // btn_VizitaCurenta
            // 
            this.btn_VizitaCurenta.FlatAppearance.BorderSize = 0;
            this.btn_VizitaCurenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VizitaCurenta.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VizitaCurenta.ForeColor = System.Drawing.Color.White;
            this.btn_VizitaCurenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_VizitaCurenta.Image")));
            this.btn_VizitaCurenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VizitaCurenta.Location = new System.Drawing.Point(-1, -1);
            this.btn_VizitaCurenta.Name = "btn_VizitaCurenta";
            this.btn_VizitaCurenta.Size = new System.Drawing.Size(278, 100);
            this.btn_VizitaCurenta.TabIndex = 2;
            this.btn_VizitaCurenta.Text = "     Current Visit";
            this.btn_VizitaCurenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_VizitaCurenta.UseVisualStyleBackColor = true;
            this.btn_VizitaCurenta.Click += new System.EventHandler(this.btn_VizitaCurenta_Click);
            // 
            // btn_CautaVizite
            // 
            this.btn_CautaVizite.FlatAppearance.BorderSize = 0;
            this.btn_CautaVizite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CautaVizite.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CautaVizite.ForeColor = System.Drawing.Color.White;
            this.btn_CautaVizite.Image = ((System.Drawing.Image)(resources.GetObject("btn_CautaVizite.Image")));
            this.btn_CautaVizite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CautaVizite.Location = new System.Drawing.Point(0, 105);
            this.btn_CautaVizite.Name = "btn_CautaVizite";
            this.btn_CautaVizite.Size = new System.Drawing.Size(277, 100);
            this.btn_CautaVizite.TabIndex = 3;
            this.btn_CautaVizite.Text = "     Visualize All Visits";
            this.btn_CautaVizite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CautaVizite.UseVisualStyleBackColor = true;
            this.btn_CautaVizite.Click += new System.EventHandler(this.btn_CautaVizite_Click);
            // 
            // btn_ToateProgramarile
            // 
            this.btn_ToateProgramarile.FlatAppearance.BorderSize = 0;
            this.btn_ToateProgramarile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ToateProgramarile.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ToateProgramarile.ForeColor = System.Drawing.Color.White;
            this.btn_ToateProgramarile.Image = ((System.Drawing.Image)(resources.GetObject("btn_ToateProgramarile.Image")));
            this.btn_ToateProgramarile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ToateProgramarile.Location = new System.Drawing.Point(-1, 211);
            this.btn_ToateProgramarile.Name = "btn_ToateProgramarile";
            this.btn_ToateProgramarile.Size = new System.Drawing.Size(278, 100);
            this.btn_ToateProgramarile.TabIndex = 4;
            this.btn_ToateProgramarile.Text = "     Visualize All          Appointments";
            this.btn_ToateProgramarile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ToateProgramarile.UseVisualStyleBackColor = true;
            this.btn_ToateProgramarile.Click += new System.EventHandler(this.btn_ToateProgramarile_Click);
            // 
            // btn_CreazaProgramare
            // 
            this.btn_CreazaProgramare.FlatAppearance.BorderSize = 0;
            this.btn_CreazaProgramare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreazaProgramare.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreazaProgramare.ForeColor = System.Drawing.Color.White;
            this.btn_CreazaProgramare.Image = ((System.Drawing.Image)(resources.GetObject("btn_CreazaProgramare.Image")));
            this.btn_CreazaProgramare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreazaProgramare.Location = new System.Drawing.Point(-1, 317);
            this.btn_CreazaProgramare.Name = "btn_CreazaProgramare";
            this.btn_CreazaProgramare.Size = new System.Drawing.Size(278, 100);
            this.btn_CreazaProgramare.TabIndex = 5;
            this.btn_CreazaProgramare.Text = "      Create New          Appointment";
            this.btn_CreazaProgramare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CreazaProgramare.UseVisualStyleBackColor = true;
            this.btn_CreazaProgramare.Click += new System.EventHandler(this.btn_CreazaProgramare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Up_Panel
            // 
            this.Up_Panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.Up_Panel.Controls.Add(this.pictureBox1);
            this.Up_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Up_Panel.Location = new System.Drawing.Point(0, 0);
            this.Up_Panel.Name = "Up_Panel";
            this.Up_Panel.Size = new System.Drawing.Size(1393, 148);
            this.Up_Panel.TabIndex = 0;
            this.Up_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Up_Panel_Paint);
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.BackColor = System.Drawing.Color.White;
            this.Main_Panel.Location = new System.Drawing.Point(278, 149);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1118, 661);
            this.Main_Panel.TabIndex = 2;
            // 
            // MainApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1393, 811);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.LeftPannel);
            this.Controls.Add(this.Up_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.LeftPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Up_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LeftPannel;
        private System.Windows.Forms.Button btn_VizitaCurenta;
        private System.Windows.Forms.Button btn_SchimbariLogistice;
        private System.Windows.Forms.Button btn_ModificaProgramare;
        private System.Windows.Forms.Button btn_CreazaProgramare;
        private System.Windows.Forms.Button btn_ToateProgramarile;
        private System.Windows.Forms.Button btn_CautaVizite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Up_Panel;
        private System.Windows.Forms.Panel Main_Panel;
    }
}