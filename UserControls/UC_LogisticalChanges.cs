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
        Connection con = new Connection();
        int id = 0;
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query;
                if (comboBox_SearchBy.Text == "Treatment")
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        query = "SELECT * FROM dbo.Tratament";
                    }
                    else
                    {
                        query = "SELECT * FROM dbo.Tratament WHERE Nume = '" + txtBox_Search.Text + "'";
                    }

                }
                else if (comboBox_SearchBy.Text == "Dental Work")
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        query = "SELECT * FROM dbo.Lucrari";
                    }
                    else
                    {
                        query = "SELECT * FROM dbo.Lucrari WHERE Nume = '" + txtBox_Search.Text + "'";
                    }
                }
                else
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        query = "SELECT * FROM dbo.Diagnostic";
                    }
                    else
                    {
                        query = "SELECT * FROM dbo.Diagnostic WHERE Nume = '" + txtBox_Search.Text + "'";
                    }
                }

                DataSet set;
                set = con.ExecuteDataSet(query);

                DataTable dataTable = set.Tables[0];
                dataGridView2.DataSource = dataTable;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_InsertRecord_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (comboBox_SearchBy.Text == "Treatment")
                {
                    con.ExecuteNonQuery("INSERT INTO dbo.Tratament (Nume) VALUES ('" + txtBox_Name.Text + "')");
                }
                else if (comboBox_SearchBy.Text == "Dental Work")
                {
                    con.ExecuteNonQuery("INSERT INTO dbo.Lucrari (Nume,Pret) VALUES ('" + txtBox_Name.Text + "' , '" + Int32.Parse(txtBox_Price.Text) + "')");
                }
                else
                {
                    con.ExecuteNonQuery("INSERT INTO dbo.Diagnostic (Nume) VALUES ('" + txtBox_Name.Text + "')");
                }
                
                MessageBox.Show("Informatiile au fost introduse cu Succes!");
                con.Close();
            }

            catch (Exception)
            {

                throw;
            }
        }

        private void btn_UpdateRecord_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                if (comboBox_SearchBy.Text == "Treatment")
                {
                    con.ExecuteNonQuery("UPDATE dbo.Tratament SET Nume ='" + txtBox_Name.Text + "' WHERE Id='" + id + "' ");
                }
                else if (comboBox_SearchBy.Text == "Dental Work")
                {
                    con.ExecuteNonQuery("UPDATE dbo.Lucrari SET Nume ='" + txtBox_Name.Text + "',Pret='" + Int32.Parse(txtBox_Price.Text) + "' WHERE Id='" + id + "' ");
                }
                else
                {
                    con.ExecuteNonQuery("UPDATE dbo.Diagnostic SET Nume ='" + txtBox_Name.Text + "' WHERE Id='" + id + "' ");
                }

                MessageBox.Show("Record Updated Successfully!");
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_DeleteRecord_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                if (comboBox_SearchBy.Text == "Treatment")
                {
                    con.ExecuteNonQuery("DELETE FROM dbo.Tratament WHERE Id='" + id + "'");
                }
                else if (comboBox_SearchBy.Text == "Dental Work")
                {
                    con.ExecuteNonQuery("DELETE FROM dbo.Lucrari WHERE Id='" + id + "'");
                }
                else
                {
                    con.ExecuteNonQuery("DELETE FROM dbo.Diagnostic WHERE Id='" + id + "'");
                }
                
                MessageBox.Show("Record Deleted Successfully!");
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Name_Click(object sender, EventArgs e)
        {
            if (txtBox_Name.Text == "Name")
            {
                txtBox_Name.Text = "";
            }
        }

        private void Name_Leave(object sender, EventArgs e)
        {
            if (txtBox_Name.Text == "")
            {
                txtBox_Name.Text = "Name";
            }
        }

        private void Price_Click(object sender, EventArgs e)
        {
            if (txtBox_Price.Text == "Price")
            {
                txtBox_Price.Text = "";
            }
        }

        private void Price_Leave(object sender, EventArgs e)
        {
            if (txtBox_Price.Text == "")
            {
                txtBox_Price.Text = "Price";
            }
        }

        private void Select_All(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
             id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            if (comboBox_SearchBy.Text == "Dental Work")
            {
                txtBox_Name.Text = selectedRow.Cells[1].Value.ToString();
                txtBox_Price.Text = selectedRow.Cells[2].Value.ToString();
            }
            else
            {
                txtBox_Name.Text = selectedRow.Cells[1].Value.ToString();
            }
        }
    }
}
