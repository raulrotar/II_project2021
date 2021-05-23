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
    public partial class UC_CreateNewAppointment : UserControl
    {
        Connection con = new Connection();
        public UC_CreateNewAppointment()
        {
            InitializeComponent();
        }

        private void UC_CreateNewAppointment_Load(object sender, EventArgs e)
        {
            comboBox_Email.SelectedIndex = 0;
            PopulateComboBoxes();
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
                    string DocFullName = (setDoc.Tables[0].Rows[i][0] + " " +setDoc.Tables[0].Rows[i][1]);
                    string AsistFullName = (setAsist.Tables[0].Rows[i][0] + " " + setAsist.Tables[0].Rows[i][1]);
                    if (cmbBox_Doctor.Items.Contains(DocFullName))
                    {

                    }
                    else
                    {
                        cmbBox_Doctor.Items.Add(DocFullName);
                    }

                    if (cmbBox_Assistant.Items.Contains(AsistFullName))
                    {

                    }
                    else
                    {
                        cmbBox_Assistant.Items.Add(AsistFullName);
                    }
                }
                cmbBox_Assistant.SelectedIndex = 0;
                cmbBox_Doctor.SelectedIndex = 0;

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

        private void btn_Create_Click(object sender, EventArgs e)
        {

        }
    }
}
