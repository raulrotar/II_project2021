﻿using System;
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
    public partial class UC_VisualizeAllVisits : UserControl
    {
        Verifier verifier = new Verifier();
        Connection con = new Connection();
        Int64 userCNP;
        char position;
        public UC_VisualizeAllVisits(Int64 userCNP, char position)
        {
            InitializeComponent();
            this.userCNP = userCNP;
            this.position = position;
        }

        private void UC_VisualizeAllVisits_Load(object sender, EventArgs e)
        {
            comboBox_SearchBy.SelectedIndex = 0;
            if (position == 'd')
            {
                helloLabel.Text = "Hello Dr. " + verifier.SetUserName(userCNP, position);
                con.Open();
                string query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor='"+userCNP+"'";
                DataSet set;
                set = con.ExecuteDataSet(query);
                DataTable dataTable = set.Tables[0];
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
            else
            {
                helloLabel.Text = "Hello Asist. " + verifier.SetUserName(userCNP, position);
                con.Open();
                string query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "'";
                DataSet set;
                set = con.ExecuteDataSet(query);
                DataTable dataTable = set.Tables[0];
                dataGridView1.DataSource = dataTable;
                con.Close();
            }

            
        }

        private void btn_ClearSearchFields_Click(object sender, EventArgs e)
        {
            txtBox_Search.Text = "Search Here";
            comboBox_SearchBy.SelectedIndex = 0;
        }

        private void VAV_Click(object sender, EventArgs e)
        {
            if (txtBox_Search.Text=="Search Here")
            {
                txtBox_Search.Text = "";
            }
        }

        private void VAV_Enter(object sender, EventArgs e)
        {
            if (txtBox_Search.Text == "Search Here")
            {
                txtBox_Search.Text = "";
            }
        }

        private void VAV_Leave(object sender, EventArgs e)
        {
            if (txtBox_Search.Text == "")
            {
                txtBox_Search.Text = "Search Here";
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query;
                if(position == 'd')
                {
                    if (comboBox_SearchBy.Text == "Month")
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='"+userCNP+"' ORDER BY MONTH(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' AND MONTH(Ziua) LIKE '%" + txtBox_Search.Text + "%'";
                        }
                    }
                    else if (comboBox_SearchBy.Text == "Year")
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' ORDER BY YEAR(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' AND YEAR(Ziua) LIKE '%" + txtBox_Search.Text + "%' ";
                        }
                    }

                    else
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' ORDER BY DAY(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' AND DAY(Ziua) LIKE '%" + txtBox_Search.Text + "%' ";
                        }
                    }
                }
                else
                {
                    if (comboBox_SearchBy.Text == "Month")
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='"+userCNP+"' ORDER BY MONTH(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' AND MONTH(Ziua) LIKE '%" + txtBox_Search.Text + "%'";
                        }
                    }
                    else if (comboBox_SearchBy.Text == "Year")
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' ORDER BY YEAR(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' AND YEAR(Ziua) LIKE '%" + txtBox_Search.Text + "%' ";
                        }
                    }

                    else
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' ORDER BY DAY(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' AND DAY(Ziua) LIKE '%" + txtBox_Search.Text + "%' ";
                        }
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

        private void VAV_TextChanged(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                string query;
                if (position == 'd')
                {
                    if (comboBox_SearchBy.Text == "Month")
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' ORDER BY MONTH(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' AND MONTH(Ziua) LIKE '%" + txtBox_Search.Text + "%'";
                        }
                    }
                    else if (comboBox_SearchBy.Text == "Year")
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' ORDER BY YEAR(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' AND YEAR(Ziua) LIKE '%" + txtBox_Search.Text + "%' ";
                        }
                    }

                    else
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' ORDER BY DAY(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Doctor ='" + userCNP + "' AND DAY(Ziua) LIKE '%" + txtBox_Search.Text + "%' ";
                        }
                    }
                }
                else
                {
                    if (comboBox_SearchBy.Text == "Month")
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' ORDER BY MONTH(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' AND MONTH(Ziua) LIKE '%" + txtBox_Search.Text + "%'";
                        }
                    }
                    else if (comboBox_SearchBy.Text == "Year")
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' ORDER BY YEAR(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' AND YEAR(Ziua) LIKE '%" + txtBox_Search.Text + "%' ";
                        }
                    }

                    else
                    {

                        if (txtBox_Search.Text == "Search Here")
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' ORDER BY DAY(Ziua) DESC";
                        }
                        else
                        {
                            query = "SELECT * FROM dbo.Vizita WHERE CNP_Asistent='" + userCNP + "' AND DAY(Ziua) LIKE '%" + txtBox_Search.Text + "%' ";
                        }
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
