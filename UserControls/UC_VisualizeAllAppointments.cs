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
    public partial class UC_VisualizeAllAppointments : UserControl
    {
        public UC_VisualizeAllAppointments()
        {
            InitializeComponent();
        }

        private void UC_VisualizeAllAppointments_Load(object sender, EventArgs e)
        {
            comboBox_SearchBy.SelectedIndex = 0;
        }

        private void VAA_Click(object sender, EventArgs e)
        {
            if (txtBox_Search.Text == "Search Here")
            {
                txtBox_Search.Text = "";
            }
        }

        private void VAA_Enter(object sender, EventArgs e)
        {
            if (txtBox_Search.Text == "Search Here")
            {
                txtBox_Search.Text = "";
            }
        }

        private void VAA_Leave(object sender, EventArgs e)
        {
            if (txtBox_Search.Text == "")
            {
                txtBox_Search.Text = "Search Here";
            }
        }

        private void btn_ClearSearchFields_Click(object sender, EventArgs e)
        {
            txtBox_Search.Text = "Search Here";
            comboBox_SearchBy.SelectedIndex = 0;
        }
    }
}
