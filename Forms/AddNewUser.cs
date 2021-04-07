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

namespace ProiectII.Forms
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
            PopulateEmailComboBox();
            comboBox_ShowDoctors.Visible = false;

        }

        private void PopulateEmailComboBox()
        {
            comboBox_Email.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Totul e ok!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region txtBox_FirstName
        private void txtBox_FirstName_Leave(object sender, EventArgs e)
        {
            if (txtBox_FirstName.Text == "")
            {
                txtBox_FirstName.Text = "First Name";
            }
        }

        private void txtBox_FirstName_Enter(object sender, EventArgs e)
        {
            if (txtBox_FirstName.Text == "First Name")
            {
                txtBox_FirstName.Text = "";
            }
        }

        private void txtBox_FirstName_Click(object sender, EventArgs e)
        {
            if (txtBox_FirstName.Text == "First Name")
            {
                txtBox_FirstName.Text = "";
            }
        }
        #endregion

        #region txtBox_NIN
        private void txtBox_NIN_Leave(object sender, EventArgs e)
        {
            if (txtBox_NIN.Text == "")
            {
                txtBox_NIN.Text = "National Identification Number";
            }
        }

        private void txtBox_NIN_Enter(object sender, EventArgs e)
        {
            if (txtBox_NIN.Text == "National Identification Number")
            {
                txtBox_NIN.Text = "";
            }
        }

        private void txtBox_NIN_Click(object sender, EventArgs e)
        {
            if (txtBox_NIN.Text == "National Identification Number")
            {
                txtBox_NIN.Text = "";
            }
        }
        #endregion
        
        #region txtBox_LastName
        private void txtBox_LastName_Click(object sender, EventArgs e)
        {
            if (txtBox_LastName.Text== "Last Name")
            {
                txtBox_LastName.Text = "";
            }
        }

        private void txtBox_LastName_Enter(object sender, EventArgs e)
        {
            if (txtBox_LastName.Text == "Last Name")
            {
                txtBox_LastName.Text = "";
            }
        }

        private void txtBox_LastName_Leave(object sender, EventArgs e)
        {
            if (txtBox_LastName.Text == "")
            {
                txtBox_LastName.Text = "Last Name";
            }
        }
        #endregion

        #region Email Address
        private void txtBox_EmailAddress_Click(object sender, EventArgs e)
        {
            if (txtBox_EmailAddress.Text=="Email Address")
            {
                txtBox_EmailAddress.Text = "";
            }
        }

        private void txtBox_EmailAddress_Enter(object sender, EventArgs e)
        {
            if (txtBox_EmailAddress.Text == "Email Address")
            {
                txtBox_EmailAddress.Text = "";
            }
        }

        private void txtBox_EmailAddress_Leave(object sender, EventArgs e)
        {
            if (txtBox_EmailAddress.Text == "")
            {
                txtBox_EmailAddress.Text = "Email Address";
            }
        }
        #endregion

        #region Security Code
        private void txtBox_SecurityCode_Click(object sender, EventArgs e)
        {
            if (txtBox_SecurityCode.Text=="Security Code")
            {
                txtBox_SecurityCode.Text = "";
            }
        }

        private void txtBox_SecurityCode_Enter(object sender, EventArgs e)
        {
            if (txtBox_SecurityCode.Text == "Security Code")
            {
                txtBox_SecurityCode.Text = "";
            }
        }

        private void txtBox_SecurityCode_Leave(object sender, EventArgs e)
        {
            if (txtBox_SecurityCode.Text == "")
            {
                txtBox_SecurityCode.Text = "Security Code";
            }
        }

        #endregion

        #region Username
        private void txtBox_Username_Click(object sender, EventArgs e)
        {
            if (txtBox_Username.Text=="Username")
            {
                txtBox_Username.Text = "";
            }
            
        }

        private void txtBox_Username_Enter(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == "Username")
            {
                txtBox_Username.Text = "";
            }
        }

        private void txtBox_Username_Leave(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == "")
            {
                txtBox_Username.Text = "Username";
            }
        }
        #endregion

        #region Password
        private void txtBox_Password_Click(object sender, EventArgs e)
        {
            if (txtBox_Password.Text=="Password")
            {
                txtBox_Password.Text = "";
            }
        }

        private void txtBox_Password_Enter(object sender, EventArgs e)
        {
            if (txtBox_Password.Text == "Password")
            {
                txtBox_Password.Text = "";
            }
        }

        private void txtBox_Password_Leave(object sender, EventArgs e)
        {
            if (txtBox_Password.Text == "")
            {
                txtBox_Password.Text = "Password";
            }
        }
        #endregion

        #region Confirm Password
        private void txtBox_ConfirmPassword_Click(object sender, EventArgs e)
        {
            if (txtBox_ConfirmPassword.Text=="Confirm Password")
            {
                txtBox_ConfirmPassword.Text = "";
            }
        }

        private void txtBox_ConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtBox_ConfirmPassword.Text == "Confirm Password")
            {
                txtBox_ConfirmPassword.Text = "";
            }
        }

        private void txtBox_ConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtBox_ConfirmPassword.Text == "")
            {
                txtBox_ConfirmPassword.Text = "Confirm Password";
            }
        }
        #endregion

        #region Aditional Information Icons
        private void picBox_Example_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is how the aditional information will be shown to you!","Additional Information Example");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are a nurse please select the name of the doctor that you will be working with from the list down below.", "Nurse Information");
        }

        private void picBox_SecurityCodeInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The security code that you enter will be required for the reset of your password so it is recommended to remember it. In case you forgot it you can recive it in an email." +
                "The option to recive the security code on the email will be on the Reset Password Window.","Security Code Information");
        }

        private void picBox_UsernameInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Username will be required for the autentification.","Username Information");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Password will be required for the autentification.", "Password Information");
        }


        #endregion

        private void radioBtn_Nurse_CheckedChanged(object sender, EventArgs e)
        {
           comboBox_ShowDoctors.Visible = true;
            PopulateDoctorsComboBox();
        }

        private void PopulateDoctorsComboBox()
        {
            Connection conn = new Connection();
            try
            {
               conn.Open();
                string query = "select Nume,Prenume from dbo.Doctori";
                DataSet set;
                set = conn.ExecuteDataSet(query);
              
                for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                {
                    string fullName = (set.Tables[0].Rows[i][0] + " " + set.Tables[0].Rows[i][1]);
                    if (comboBox_ShowDoctors.Text != fullName)
                    {
                       comboBox_ShowDoctors.Items.Add(set.Tables[0].Rows[i][0] + " " + set.Tables[0].Rows[i][1]);
                    }
                }
                comboBox_ShowDoctors.SelectedIndex = 0;
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void radioBtn_Doctor_CheckedChanged(object sender, EventArgs e)
        {
            if ((comboBox_ShowDoctors.Visible)==true)
            {
                comboBox_ShowDoctors.Visible = false;
            }
        }

      
    }
}
