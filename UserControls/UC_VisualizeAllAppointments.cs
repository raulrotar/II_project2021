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
        Connection con = new Connection();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            con.Open();
            string query;
            try
            {
                if (comboBox_SearchBy.Text == "Month")
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        query = "SELECT * FROM dbo.Programare ORDER BY MONTH(Ziua) DESC";
                    }

                    else
                    {
                        query = "SELECT * FROM dbo.Programare WHERE MONTH(Ziua)='" + txtBox_Search.Text + "'";
                    }

                }
                else if (comboBox_SearchBy.Text == "Year")
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        query = "SELECT * FROM dbo.Programare ORDER BY YEAR(Ziua) DESC";
                    }

                    else
                    {
                        query = "SELECT * FROM dbo.Programare WHERE YEAR(Ziua)='" + txtBox_Search.Text + "'";
                    }

                }
                else
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        query = "SELECT * FROM dbo.Programare ORDER BY DAY(Ziua) DESC";
                    }

                    else
                    {
                        query = "SELECT * FROM dbo.Programare WHERE DAY(Ziua)='" + txtBox_Search.Text + "'";
                    }

                }

                DataSet set;
                set = con.ExecuteDataSet(query);
                DataTable dataTable = set.Tables[0];
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
