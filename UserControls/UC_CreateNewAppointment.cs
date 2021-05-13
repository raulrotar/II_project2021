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

        }
        #region Patient
        private void Patient_Leave(object sender, EventArgs e)
        {
            if (txtBox_PatientName.Text == "")
            {
                txtBox_PatientName.Text = "Patient Name";
            }
        }

        private void Patient_Click(object sender, EventArgs e)
        {
            if (txtBox_PatientName.Text == "Patient Name")
            {
                txtBox_PatientName.Text = "";
            }
        }

        private void Patient_Enter(object sender, EventArgs e)
        {
            if (txtBox_PatientName.Text == "Patient Name")
            {
                txtBox_PatientName.Text = "";
            }
        }
        #endregion

        #region Doctor's Name
        private void Doctor_Click(object sender, EventArgs e)
        {
            if (txtBox_DoctorName.Text == "Doctor's Name")
            {
                txtBox_DoctorName.Text = "";
            }
        }

        private void Doctor_Enter(object sender, EventArgs e)
        {
            if (txtBox_DoctorName.Text == "Doctor's Name")
            {
                txtBox_DoctorName.Text = "";
            }
        }

        private void Doctor_Leave(object sender, EventArgs e)
        {
            if (txtBox_DoctorName.Text == "")
            {
                txtBox_DoctorName.Text = "Doctor's Name";
            }
        }


        #endregion

        #region Assistant's Name
        private void Assistant_Name(object sender, EventArgs e)
        {
            if (txtBox_AssistantName.Text=="Assistant's Name")
            {
                txtBox_AssistantName.Text = "";
            }
        }

        private void Assistant_Enter(object sender, EventArgs e)
        {
            if (txtBox_AssistantName.Text == "Assistant's Name")
            {
                txtBox_AssistantName.Text = "";
            }
        }

        private void Assistant_Leave(object sender, EventArgs e)
        {
            if (txtBox_AssistantName.Text == "")
            {
                txtBox_AssistantName.Text = "Assistant's Name";
            }
        }

        #endregion

        #region Hour
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
        }

        private void Hour_Enter(object sender, EventArgs e)
        {
            if (txtBox_Hour.Text == "Hour")
            {
                txtBox_Hour.Text = "";
            }
        }


        #endregion

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_AssistantName.Text = "Assistant's Name";
            txtBox_PatientName.Text = "Patient Name";
            txtBox_DoctorName.Text = "Doctor's Name";
            txtBox_Hour.Text = "Hour";
        }
    }
}
