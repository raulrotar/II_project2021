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
        public UC_CreateNewAppointment()
        {
            InitializeComponent();
        }

        private void UC_CreateNewAppointment_Load(object sender, EventArgs e)
        {
            comboBox_Email.SelectedIndex = 0;
        }
      

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_AssistantName.Text = "Assistant's Name";
            txtBox_PatientFName.Text = "Patient First Name";
            txtBox_DoctorName.Text = "Doctor's Name";
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
