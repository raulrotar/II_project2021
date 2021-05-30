using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectII.UserControls
{
    public partial class UC_ModifyExistingAppointment : UserControl
    {
        Verifier verifier = new Verifier();
        Connection con = new Connection();
        Int64 userCNP;
        char position;
        Int64 id = 0;

        public UC_ModifyExistingAppointment(Int64 userCNP, char position)
        {
            InitializeComponent();
            this.userCNP = userCNP;
            this.position = position;
        }

        private void UC_ModifyExistingAppointment_Load(object sender, EventArgs e)
        {
            comboBox_SearchBy.SelectedIndex = 0;
            comboBox_Email.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
            PopulateComboBoxes();
            string query = "";
            if (position == 'd')
            {
                helloLabel.Text = "Hello Dr. " + verifier.SetUserName(userCNP, position);
                query = "SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor='"+userCNP+"'";
            }
            else
            {
                helloLabel.Text = "Hello Asist. " + verifier.SetUserName(userCNP, position);
                query = "SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent='" + userCNP + "'";
                cmbBox_Assistant.Visible = false;
                pictureBox5.Visible = false;
                panel4.Visible = false;
            }

            con.Open();
            DataSet set;
            set = con.ExecuteDataSet(query);
            DataTable dataTable = set.Tables[0];
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void PopulateComboBoxes()
        {
            try
            {
                con.Open();
                string queryAsist = "SELECT Nume,Prenume FROM dbo.Asistenti";
                DataSet setAsist;
                setAsist = con.ExecuteDataSet(queryAsist);
                for (int i = 0; i < setAsist.Tables[0].Rows.Count; i++)
                {
                    
                    string AsistFullName = (setAsist.Tables[0].Rows[i][0] + " " + setAsist.Tables[0].Rows[i][1]);
                   
                 
                    if (cmbBox_Assistant.Items.Contains(AsistFullName))
                    {

                    }
                    else
                    {
                        cmbBox_Assistant.Items.Add(AsistFullName);
                    }
                }

                cmbBox_Assistant.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataSet set;
                if(position == 'd')
                {
                    if (comboBox_SearchBy.Text == "Date")
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP+"' ORDER BY Ziua DESC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' AND Ziua LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                    else if (comboBox_SearchBy.Text == "Hour")
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' ORDER BY Ora ASC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' AND Ora LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                    else
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' ORDER BY NumePacient ASC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' AND NumePacient LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                }
                else
                {
                    if (comboBox_SearchBy.Text == "Date")
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP+"' ORDER BY Ziua DESC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' AND Ziua LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                    else if (comboBox_SearchBy.Text == "Hour")
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' ORDER BY Ora ASC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' AND Ora LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                    else
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' ORDER BY NumePacient ASC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' AND NumePacient LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                }
                 
                DataTable dataTable = set.Tables[0];
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Select_ALL(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                if (selectedRow.Cells[0].Value.ToString() != "")
                {
                    id = Int64.Parse(selectedRow.Cells[0].Value.ToString());
                    txtBox_PatientLName.Text = selectedRow.Cells[1].Value.ToString();
                    txtBox_PatientFName.Text = selectedRow.Cells[2].Value.ToString();
                    txtBox_PatientNIN.Text = selectedRow.Cells[3].Value.ToString();
                    txtBox_PatientAge.Text = selectedRow.Cells[4].Value.ToString();
                    txtBox_PatientPhoneNr.Text = selectedRow.Cells[5].Value.ToString();
                    string[] Email = (selectedRow.Cells[6].Value.ToString()).Split('@');
                    txtBox_EmailAddress.Text = Email[0];
                    dateTimePicker.Value = DateTime.Parse(selectedRow.Cells[9].Value.ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    txtBox_Hour.Text = selectedRow.Cells[10].Value.ToString();
                }
            }
        }
        public bool CheckAvailabilility(DateTime date, string Hour)
        {
            DateTime hour = DateTime.Parse(Hour, System.Globalization.CultureInfo.CurrentCulture);
            DataSet set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua='" + date + "' AND Ora='" + hour + "'");
            if (set.Tables[0].Rows.Count > 1)
            {
                return false;
            }

            return true;
        }
        public bool CheckForPatient(string NIN)
        {
            Int64 CNP = Int64.Parse(NIN);
            DataSet set = con.ExecuteDataSet("SELECT * FROM dbo.Pacienti WHERE CNP='" + Int64.Parse(NIN) + "'");
            if (set.Tables[0].Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Int64 DocCNP = 1, AsistCNP = 1;

                if(position == 'd')
                {
                    DocCNP = userCNP;
                    string[] AsistName = (cmbBox_Assistant.Text).Split(' ');
                    SqlDataReader AsistNameReader = con.ExecuteReader("Select CNP from dbo.Asistenti where Nume='" + AsistName[0] + "' AND Prenume='" + AsistName[1] + "'");
                    while (AsistNameReader.Read())
                    {
                        AsistCNP = AsistNameReader.GetInt64(0);
                    }
                    AsistNameReader.Close();
                }
                else
                {
                    AsistCNP = userCNP;
                    SqlDataReader docCNPReader = con.ExecuteReader("Select CNP_Doctor from dbo.Asistenti where CNP='" + AsistCNP + "'");
                    while (docCNPReader.Read())
                    {
                        DocCNP = docCNPReader.GetInt64(0);
                    }
                    docCNPReader.Close();
                }
                
                
                

                if (verifier.CheckNIN(txtBox_PatientNIN.Text) && verifier.CheckName(txtBox_PatientFName.Text) && verifier.CheckName(txtBox_PatientLName.Text) && verifier.CheckAge(txtBox_PatientAge.Text))
                {
                    if (verifier.CheckDate(dateTimePicker.Value) && verifier.CheckHour(txtBox_Hour.Text))
                    {
                        if (CheckAvailabilility(dateTimePicker.Value,txtBox_Hour.Text))
                        {
                            con.ExecuteNonQuery("UPDATE dbo.Programare SET NumePacient='"+txtBox_PatientLName.Text+"', PrenumePacient='"+txtBox_PatientFName.Text+"',CNP_Pacient='"+Int64.Parse(txtBox_PatientNIN.Text)+"',Varsta='"+Int32.Parse(txtBox_PatientAge.Text)+"' , NrTelefon='"+Int32.Parse(txtBox_PatientPhoneNr.Text)+"',Email='"+txtBox_EmailAddress.Text +comboBox_Email.Text+"',CNP_Doctor='"+DocCNP+"',CNP_Asistent='"+AsistCNP+"',Ziua='"+dateTimePicker.Value+"',Ora='"+DateTime.Parse(txtBox_Hour.Text,System.Globalization.CultureInfo.CurrentCulture)+"'  WHERE Id='"+id+"'");
                            con.ExecuteNonQuery("UPDATE dbo.Pacienti SET CNP_Doctor='"+DocCNP+"',CNP_Asistent='"+AsistCNP+"',Nume='"+txtBox_PatientLName.Text+"',Prenume='"+txtBox_PatientFName.Text+"',Varsta='"+Int32.Parse(txtBox_PatientAge.Text)+"',Nr_Telefon='"+Int32.Parse(txtBox_PatientPhoneNr.Text)+"',Email='"+txtBox_EmailAddress.Text + comboBox_Email.Text+"'  WHERE CNP='"+Int64.Parse(txtBox_PatientNIN.Text)+"'");
                            MessageBox.Show("Appointment Updated Successfully!!!");
                        }
                        else
                        {
                            MessageBox.Show("The date and hour you selected are not available!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a date that is not in the past and an Hour between 08:00 and 16:00!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Information was introduced in the wrong format!!!");
                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Modify_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataSet set;
                if (position == 'd')
                {
                    if (comboBox_SearchBy.Text == "Date")
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' ORDER BY Ziua DESC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' AND Ziua LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                    else if (comboBox_SearchBy.Text == "Hour")
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' ORDER BY Ora ASC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' AND Ora LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                    else
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' ORDER BY NumePacient ASC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Doctor = '" + userCNP + "' AND NumePacient LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                }
                else
                {
                    if (comboBox_SearchBy.Text == "Date")
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' ORDER BY Ziua DESC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' AND Ziua LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                    else if (comboBox_SearchBy.Text == "Hour")
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' ORDER BY Ora ASC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' AND Ora LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                    else
                    {
                        if (txtBox_Search.Text == "Search Here")
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' ORDER BY NumePacient ASC");
                        }
                        else
                        {
                            set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua > '" + DateTime.Now.Date + "' AND CNP_Asistent = '" + userCNP + "' AND NumePacient LIKE '%" + txtBox_Search.Text + "%'");
                        }
                    }
                }
                DataTable dataTable = set.Tables[0];
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MEA_Click(object sender, EventArgs e)
        {
            if (txtBox_Search.Text == "Search Here")
            {
                txtBox_Search.Text = "";
            }
        }

        private void MEA_Leave(object sender, EventArgs e)
        {
            if (txtBox_Search.Text == "")
            {
                txtBox_Search.Text = "Search Here";
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                con.ExecuteNonQuery("DELETE FROM dbo.Programare WHERE Id='"+id+"'");
                MessageBox.Show("Record Deleted Successfully!!");
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_PatientFName.Text = "Patient First Name";
            txtBox_Hour.Text = "Hour";
            txtBox_PatientLName.Text = "Patient Last Name";
            txtBox_PatientNIN.Text = "Patient NIN";
            txtBox_PatientAge.Text = "Patient Age";
            txtBox_PatientPhoneNr.Text = "Patient Phone Number";
            txtBox_EmailAddress.Text = "Email Address";
        }

        #region Patient Personal Info 

        //Patient First Name 
        private void PFN_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientFName.Text == "Patient First Name")
            {
                txtBox_PatientFName.Text = "";
            }
        }
        private void PFN_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientFName.Text == "")
            {
                txtBox_PatientFName.Text = "Patient First Name";
            }
        }

        //Patient Last Name
        private void PLN_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientLName.Text == "Patient Last Name")
            {
                txtBox_PatientLName.Text = "";
            }
        }

        private void PLN_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientLName.Text == "")
            {
                txtBox_PatientLName.Text = "Patient Last Name";
            }
        }

        //Patient National Identification Number
        private void PNIN_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientNIN.Text == "Patient NIN")
            {
                txtBox_PatientNIN.Text = "";
            }
        }

        private void PNIN_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientNIN.Text == "")
            {
                txtBox_PatientNIN.Text = "Patient NIN";
            }
        }

        //Patient Age
        private void PAge_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientAge.Text == "Patient Age")
            {
                txtBox_PatientAge.Text = "";
            }
        }

        private void PAge_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientAge.Text == "")
            {
                txtBox_PatientAge.Text = "Patient Age";
            }
        }

        //PAtient Phone Number
        private void PPN_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientPhoneNr.Text == "Patient Phone Number")
            {
                txtBox_PatientPhoneNr.Text = "";
            }
        }

        private void PPN_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientPhoneNr.Text == "")
            {
                txtBox_PatientPhoneNr.Text = "Patient Phone Number";
            }
        }

        //Patient Email Address
        private void PEmailAddress_Click(object sender, EventArgs e)
        {
            if (txtBox_EmailAddress.Text == "Email Address")
            {
                txtBox_EmailAddress.Text = "";
            }
        }

        private void PEmailAddress_Leave(object sender, EventArgs e)
        {
            if (txtBox_EmailAddress.Text == "")
            {
                txtBox_EmailAddress.Text = "Email Address";
            }
        }

        private void Hour_Click(object sender, EventArgs e)
        {
            if (txtBox_Hour.Text == "Hour")
            {
                txtBox_Hour.Text = "";
            }
        }

        private void Hour_Leave(object sender, EventArgs e)
        {
            if (txtBox_Hour.Text == "")
            {
                txtBox_Hour.Text = "Hour";
            }

            if (!verifier.CheckHour(txtBox_Hour.Text) )
            {
                MessageBox.Show("The hour is not in a corect format!!!  Please use this format Hour:Minutes");
                return;
            }
            else
            {
                DateTime hour = DateTime.Parse(txtBox_Hour.Text, System.Globalization.CultureInfo.CurrentCulture);
                if (hour.Minute == 30 || hour.Minute == 0)
                {
                    
                }
                else
                {
                    MessageBox.Show("Visits take place every 30 minutes;  minutes are:" + hour.Minute);
                }
            }


        }

        #endregion

        private void EmailAddress_TextChanged(object sender, EventArgs e)
        {
            if (!verifier.CheckEmailAddress(txtBox_EmailAddress.Text))
            {
                MessageBox.Show("Please insert a valid email address!!!");
            }
        }


    }
}
