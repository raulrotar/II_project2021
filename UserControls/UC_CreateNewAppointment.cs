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
    public partial class UC_CreateNewAppointment : UserControl
    {
        Verifier verifier = new Verifier();
        Connection con = new Connection();
        Int64 userCNP;
        char position;
        public UC_CreateNewAppointment(Int64 userCNP,char position)
        {
            InitializeComponent();
            this.userCNP = userCNP;
            this.position = position;
        }

        private void UC_CreateNewAppointment_Load(object sender, EventArgs e)
        {
            comboBox_Email.SelectedIndex = 0;
            
            dateTimePicker.Value = DateTime.Now;
            Hour_Ok.Visible = false;
            if(position == 'd')
            {
                helloLabel.Text = "Hello Dr. " + verifier.SetUserName(userCNP, position);
                PopulateComboBoxes();

            }
            else
            {
                helloLabel.Text = "Hello Asist. " + verifier.SetUserName(userCNP, position);
                cmbBox_Assistant.Visible = false;
                pictureBox5.Visible = false;
                panel3.Visible = false;
            }
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

        // Check if the hour is available
        public bool CheckAvailabilility(DateTime date , string Hour)
        {
            DateTime hour = DateTime.Parse(Hour,System.Globalization.CultureInfo.CurrentCulture);
            DataSet set = con.ExecuteDataSet("SELECT * FROM dbo.Programare WHERE Ziua='"+date+"' AND Ora='"+hour+"'");
            if (set.Tables[0].Rows.Count > 0)
            {
                return false;
            }

            return true;
        }
        public bool CheckForPatient(string NIN)
        {
            Int64 CNP = Int64.Parse(NIN);
            DataSet set = con.ExecuteDataSet("SELECT * FROM dbo.Pacienti WHERE CNP='"+Int64.Parse(NIN)+"'");
            if (set.Tables[0].Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                Int64 DocCNP = 1111111111111, AsistCNP = 1222222222222;
                string[] AsistName = (cmbBox_Assistant.Text).Split(' ');

                if(position =='d')
                {
                    DocCNP = userCNP;
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
                    SqlDataReader docCNPReader = con.ExecuteReader("Select CNP_Doctor from dbo.Asistenti where CNP='"+AsistCNP+"'");
                    while (docCNPReader.Read())
                    {
                        DocCNP = docCNPReader.GetInt64(0);
                    }
                    docCNPReader.Close();
                }

                if (verifier.CheckNIN(txtBox_PatientNIN.Text) && verifier.CheckName(txtBox_PatientFName.Text) && verifier.CheckName(txtBox_PatientLName.Text) && verifier.CheckPhoneNumber(txtBox_PatientPhoneNr.Text) && verifier.CheckAge(txtBox_PatientAge.Text))
                {
                    if (verifier.CheckDate(dateTimePicker.Value) && verifier.CheckHour(txtBox_Hour.Text))
                    {
                        if (CheckAvailabilility(dateTimePicker.Value,txtBox_Hour.Text))
                        {
                            if (CheckForPatient(txtBox_PatientNIN.Text))
                            {
                                con.ExecuteNonQuery("INSERT INTO dbo.Pacienti (CNP,CNP_Doctor,CNP_Asistent,Nume,Prenume,Varsta,Nr_Telefon,Email) VALUES('" + Int64.Parse(txtBox_PatientNIN.Text) + "','" + DocCNP + "','" + AsistCNP + "','" + txtBox_PatientLName.Text + "','" + txtBox_PatientFName.Text + "','" + Int32.Parse(txtBox_PatientAge.Text) + "','" + Int32.Parse(txtBox_PatientPhoneNr.Text) + "','" + txtBox_EmailAddress.Text + comboBox_Email.Text + "')");
                            }
                              con.ExecuteNonQuery("INSERT INTO dbo.Programare (NumePacient,PrenumePacient,CNP_Pacient,Varsta,NrTelefon,Email,CNP_Doctor,CNP_Asistent,Ziua,Ora)  VALUES ('"+txtBox_PatientLName.Text+"','"+txtBox_PatientFName.Text+"','"+Int64.Parse(txtBox_PatientNIN.Text)+"','"+Int32.Parse(txtBox_PatientAge.Text)+"','"+Int32.Parse(txtBox_PatientPhoneNr.Text)+"','"+txtBox_EmailAddress.Text + comboBox_Email.Text+"','"+DocCNP+"','"+AsistCNP+"','"+dateTimePicker.Value+"','"+DateTime.Parse(txtBox_Hour.Text,System.Globalization.CultureInfo.CurrentCulture)+"')");
                              MessageBox.Show("The appointment was created successfully!!!");
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
                    MessageBox.Show("Informations was introduced in the wrong format!!!");
                }
                
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FName_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientFName.Text=="Patient First Name")
            {
                txtBox_PatientFName.Text = "";
            }
        }

        private void FName_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientFName.Text == "")
            {
                txtBox_PatientFName.Text = "Patient First Name";
            }
        }

        private void LName_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientLName.Text == "Patient Last Name")
            {
                txtBox_PatientLName.Text = "";
            }
        }

        private void LName_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientLName.Text == "")
            {
                txtBox_PatientLName.Text = "Patient Last Name";
            }
        }

        private void NIN_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientNIN.Text == "Patient NIN")
            {
                txtBox_PatientNIN.Text = "";
            }
        }

        private void NIN_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientNIN.Text == "")
            {
                txtBox_PatientNIN.Text = "Patient NIN";
            }
        }

        private void Age_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientAge.Text=="Patient Age")
            {
                txtBox_PatientAge.Text = "";
            }
        }

        private void Age_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientAge.Text == "")
            {
                txtBox_PatientAge.Text = "Patient Age";
            }
        }

        private void PNum_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientPhoneNr.Text == "Patient Phone Number")
            {
                txtBox_PatientPhoneNr.Text = "";
            }
        }

        private void PNum_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientPhoneNr.Text == "")
            {
                txtBox_PatientPhoneNr.Text = "Patient Phone Number";
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {
            if (txtBox_EmailAddress.Text == "Email Address")
            {
                txtBox_EmailAddress.Text = "";
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (txtBox_EmailAddress.Text == "")
            {
                txtBox_EmailAddress.Text = "Email Address";
            }
        }

        private void Hour_Click(object sender, EventArgs e)
        {
            if (txtBox_Hour.Text=="Hour")
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

            if (!verifier.CheckHour(txtBox_Hour.Text))
            {
                MessageBox.Show("The hour is not in a corect format!!!  Please use this format Hour:Minutes");
                return;
            }
            else
            {
                  DateTime hour = DateTime.Parse(txtBox_Hour.Text,System.Globalization.CultureInfo.CurrentCulture);
                    if(hour.Minute == 30 || hour.Minute == 0)
                    {
                       Hour_Ok.Visible=true;
                    }
                    else
                    { 
                        MessageBox.Show("Visits take place every 30 minutes;  minutes are:" + hour.Minute);
                    }
            }


        }
    }
}
