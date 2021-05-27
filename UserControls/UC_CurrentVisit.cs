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
    public partial class UC_CurrentVisit : UserControl
    {
        Verifier verifier = new Verifier();
        Connection con = new Connection();
        Int64 CNP_Asistant = 0, CNP_Doctor = 0;
        int Id_Lucrare = 1, Id_Diagnostic = 1,Id_Tratament=1;
        bool existsAppointments=true;
        public UC_CurrentVisit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Patient Personal Info 

        //Patient First Name 
        private void PFN_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientFName.Text=="Patient First Name")
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


        #endregion

        private void UC_CurrentVisit_Load(object sender, EventArgs e)
        {
            comboBox_Email.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            try
            {
                con.Open();
                string queryAsist = "SELECT Nume,Prenume FROM dbo.Asistenti";
                string queryDiagnostic = "Select Nume From dbo.Diagnostic";
                string queryLucrare = "Select Nume FROM dbo.Lucrari";
                string queryTratament = "SELECT Nume FROM dbo.Tratament";
                DataSet setAsist, setDiagnostic, setDentalWork, setTreatment;
             
                setAsist = con.ExecuteDataSet(queryAsist);
                setDiagnostic = con.ExecuteDataSet(queryDiagnostic);
                setDentalWork = con.ExecuteDataSet(queryLucrare);
                setTreatment = con.ExecuteDataSet(queryTratament);
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
                for (int j = 0; j < setDiagnostic.Tables[0].Rows.Count; j++)
                {
                    if (cmbBox_Diagnostic.Items.Contains(setDiagnostic.Tables[0].Rows[j][0]))
                    {

                    }
                    else
                    {
                        cmbBox_Diagnostic.Items.Add(setDiagnostic.Tables[0].Rows[j][0]);
                    }
                }
                for (int k = 0; k < setDentalWork.Tables[0].Rows.Count; k++)
                {
                    if (cmbBox_Work.Items.Contains(setDentalWork.Tables[0].Rows[k][0]))
                    {

                    }
                    else
                    {
                        cmbBox_Work.Items.Add(setDentalWork.Tables[0].Rows[k][0]);
                    }
                }
                for (int l = 0; l < setTreatment.Tables[0].Rows.Count; l++)
                {
                    if (cmbBox_Treatment.Items.Contains(setTreatment.Tables[0].Rows[l][0]))
                    {

                    }
                    else
                    {
                        cmbBox_Treatment.Items.Add(setTreatment.Tables[0].Rows[l][0]);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_NextAppointment_Click(object sender, EventArgs e)
        {      
            
                con.Open();
                DataSet set = con.ExecuteDataSet("Select * From dbo.Programare  WHERE NOT EXISTS (SELECT 1 FROM dbo.Vizita WHERE Ziua='"+DateTime.UtcNow+"' AND dbo.Programare.CNP_Pacient = CNP_Pacient) AND  Ziua='"+DateTime.UtcNow+"' ORDER BY Ora ASC");
                if (set.Tables[0].Rows.Count == 0)
                {
                    existsAppointments = false;
                    MessageBox.Show("There are no appointments left for today!!!");
                } 

                if (existsAppointments==true)
                {
                    try
                    {
                        DataTable Appointments = set.Tables[0];
                        txtBox_PatientFName.Text = (Appointments.Rows[0]["PrenumePacient"]).ToString();
                        txtBox_PatientLName.Text = (Appointments.Rows[0]["NumePacient"]).ToString();
                        txtBox_PatientNIN.Text = (Appointments.Rows[0]["CNP_Pacient"]).ToString();
                        txtBox_PatientAge.Text = (Appointments.Rows[0]["Varsta"]).ToString();
                        txtBox_PatientPhoneNr.Text =  (Appointments.Rows[0]["NrTelefon"]).ToString();
                        string[] Email = ((Appointments.Rows[0]["Email"]).ToString()).Split('@');
                        txtBox_EmailAddress.Text = Email[0];
                        CNP_Asistant = Int64.Parse((Appointments.Rows[0]["CNP_Asistent"]).ToString());
                        CNP_Doctor = Int64.Parse((Appointments.Rows[0]["CNP_Doctor"]).ToString());
                        DataSet setAsist = con.ExecuteDataSet("Select Nume,Prenume FROM dbo.Asistenti WHERE CNP='" + CNP_Asistant + "'");
                        string AsistantFullName = (setAsist.Tables[0].Rows[0][0] + " " + setAsist.Tables[0].Rows[0][1]);
                        cmbBox_Assistant.SelectedItem = AsistantFullName;
                        dateTimePicker.Value = DateTime.Parse((Appointments.Rows[0]["Ziua"]).ToString(), System.Globalization.CultureInfo.CurrentCulture);
                        txtBox_Hour.Text = (Appointments.Rows[0]["Ora"]).ToString();
                        con.Close();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            
        }

        public bool CheckAvailabilility(DateTime date, string Hour)
        {
            DateTime hour = DateTime.Parse(Hour, System.Globalization.CultureInfo.CurrentCulture);
            if (date != DateTime.Now)
            {
                return false;
            }
            DataSet set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua='" + date + "' AND Ora='" + hour + "'");
            if (set.Tables[0].Rows.Count == 0)
            {
                return false;
            }

            return true;
        }

        private void btn_FinishVisit_Click(object sender, EventArgs e)
        {
            if (existsAppointments == false)
            {
                MessageBox.Show("Visits don't happen without appointmets!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlDataReader DiagnosticReader = con.ExecuteReader("Select Id From dbo.Diagnostic WHERE Nume='" + cmbBox_Diagnostic.Text + "'");
                    while (DiagnosticReader.Read())
                    {
                        Id_Diagnostic = DiagnosticReader.GetInt32(0);
                    }
                    DiagnosticReader.Close();

                    SqlDataReader WorkReader = con.ExecuteReader("Select Id From dbo.Lucrari WHERE Nume='" + cmbBox_Work.Text + "'");
                    while (WorkReader.Read())
                    {
                        Id_Lucrare = WorkReader.GetInt32(0);
                    }
                    WorkReader.Close();

                    SqlDataReader TreatmentReader = con.ExecuteReader("Select Id From dbo.Tratament WHERE Nume='" + cmbBox_Treatment.Text + "'");
                    while (TreatmentReader.Read())
                    {
                        Id_Tratament = TreatmentReader.GetInt32(0);
                    }
                    TreatmentReader.Close();
                    if (verifier.CheckNIN(txtBox_PatientNIN.Text) && verifier.CheckName(txtBox_PatientFName.Text) && verifier.CheckName(txtBox_PatientLName.Text) && verifier.CheckPhoneNumber(txtBox_PatientPhoneNr.Text) && verifier.CheckAge(txtBox_PatientAge.Text))
                    {
                        con.ExecuteNonQuery("INSERT INTO dbo.Vizita (CNP_Doctor,CNP_Asistent,CNP_Pacient,Ora,Ziua,Id_Lucrare,Id_Diagnostic,Id_Tratament) VALUES('" + CNP_Doctor + "','" + CNP_Asistant + "','" + Int64.Parse(txtBox_PatientNIN.Text) + "','" + DateTime.Parse(txtBox_Hour.Text, System.Globalization.CultureInfo.CurrentCulture) + "','" + dateTimePicker.Value + "','" + Id_Diagnostic + "','" + Id_Lucrare + "','" + Id_Tratament + "')");
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
        }
    }
}
