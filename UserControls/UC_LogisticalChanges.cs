using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectII.UserControls
{
    public partial class UC_LogisticalChanges : UserControl
    {
        public UC_LogisticalChanges()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_LogisticalChanges_Load(object sender, EventArgs e)
        {
            comboBox_SearchBy.SelectedIndex = 0;
            picBox_Price.Visible = false;
            txtBox_Price.Visible = false;
            panel_Price.Visible = false;
        }

        private void SearchBy_Click(object sender, EventArgs e)
        {
            if (txtBox_Search.Text=="Search Here")
            {
                txtBox_Search.Text = "";
            }
        }

        private void SearchBy_Leave(object sender, EventArgs e)
        {
            if (txtBox_Search.Text == "")
            {
                txtBox_Search.Text = "Search Here";
            }
        }

        private void comboBox_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SearchBy.Text=="Dental Work")
            {
                picBox_Price.Visible = true;
                txtBox_Price.Visible = true;
                panel_Price.Visible = true;
            }
            else
            {
                picBox_Price.Visible = false;
                txtBox_Price.Visible = false;
                panel_Price.Visible = false;

            }
        }
    }
}
