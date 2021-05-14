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
    public partial class UC_CurrentVisit : UserControl
    {
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
        }
    }
}
