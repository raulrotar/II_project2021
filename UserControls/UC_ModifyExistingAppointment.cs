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
            if (position == 'd')
            {
                helloLabel.Text = "Hello Dr. " + verifier.SetUserName(userCNP, position);
            }
            else
            {
                helloLabel.Text = "Hello Asist. " + verifier.SetUserName(userCNP, position);
            }
        }

        private void PopulateComboBoxes()
        {
            try
            {
                con.Open();
                string queryDoc = "SELECT Nume,Prenume FROM dbo.Doctori";
                string queryAsist = "SELECT Nume,Prenume FROM dbo.Asistenti";
                DataSet setDoc, setAsist;
                setDoc = con.ExecuteDataSet(queryDoc);
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
                for (int i = 0; i < setDoc.Tables[0].Rows.Count; i++)
                {
                    string DocFullName = (setDoc.Tables[0].Rows[i][0] + " " + setDoc.Tables[0].Rows[i][1]);
                    if (cmbBox_Doctor.Items.Contains(DocFullName))
                    {

                    }
                    else
                    {
                        cmbBox_Doctor.Items.Add(DocFullName);
                    }
                }

                cmbBox_Assistant.SelectedIndex = 0;
                cmbBox_Doctor.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataSet set;
                 if (comboBox_SearchBy.Text == "Date")
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                       set = con.ExecuteDataSet("SELECT * FROM dbo.Programare ORDER BY Ziua DESC");
                    }
                    else
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua='" + txtBox_Search.Text + "'");
                    }
                }
                else if (comboBox_SearchBy.Text=="Hour")
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare ORDER BY Ora ASC");
                    }
                    else
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ora='" + txtBox_Search.Text + "'");
                    }
                }
                else
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare ORDER BY NumePacient ASC");
                    }
                    else
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE NumePacient='" + txtBox_Search.Text + "'");
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
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            txtBox_PatientLName.Text = selectedRow.Cells[1].Value.ToString();
            txtBox_PatientFName.Text = selectedRow.Cells[2].Value.ToString();
            txtBox_PatientNIN.Text = selectedRow.Cells[3].Value.ToString();
            txtBox_PatientAge.Text = selectedRow.Cells[4].Value.ToString();
            txtBox_PatientPhoneNr.Text = selectedRow.Cells[5].Value.ToString();
            string [] Email = (selectedRow.Cells[6].Value.ToString()).Split('@');
            txtBox_EmailAddress.Text = Email[0];
            dateTimePicker.Value =  DateTime.Parse(selectedRow.Cells[9].Value.ToString(),System.Globalization.CultureInfo.CurrentCulture);
            txtBox_Hour.Text = selectedRow.Cells[10].Value.ToString();
        }
                public bool CheckAvailabilility(DateTime date, string Hour)
                {
                    DateTime hour = DateTime.Parse(Hour, System.Globalization.CultureInfo.CurrentCulture);
                    DataSet set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua='" + date + "' AND Ora='" + hour + "'");
                    if (set.Tables[0].Rows.Count > 0)
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
                string[] DocName = (cmbBox_Doctor.Text).Split(' ');
                string[] AsistName = (cmbBox_Assistant.Text).Split(' ');

                SqlDataReader DocNameReader = con.ExecuteReader("Select CNP from dbo.Doctori where Nume='" + DocName[0] + "' AND Prenume='" + DocName[1] + "'");
                while (DocNameReader.Read())
                {
                    DocCNP = DocNameReader.GetInt64(0);
                }
                DocNameReader.Close();
           
                SqlDataReader AsistNameReader = con.ExecuteReader("Select CNP from dbo.Asistenti where Nume='" + AsistName[0] + "' AND Prenume='" + AsistName[1] + "'");
                while (AsistNameReader.Read())
                {
                    AsistCNP = AsistNameReader.GetInt64(0);
                }
                AsistNameReader.Close();

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
                if (comboBox_SearchBy.Text == "Date")
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare ORDER BY Ziua DESC");
                    }
                    else
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua LIKE '%" + txtBox_Search.Text + "%'");
                    }
                }
                else if (comboBox_SearchBy.Text == "Hour")
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare ORDER BY Ora ASC");
                    }
                    else
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ora LIKE '%" + txtBox_Search.Text + "%'");
                    }
                }
                else
                {
                    if (txtBox_Search.Text == "Search Here")
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare ORDER BY NumePacient ASC");
                    }
                    else
                    {
                        set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE NumePacient LIKE '%" + txtBox_Search.Text + "%'");
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
    }
}
