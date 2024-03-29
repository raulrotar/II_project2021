﻿using System;
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
        Verifier verifier = new Verifier();
        Connection con = new Connection();
        Int64 Doc_CNP = 1111111111111;

        public AddNewUser()
        {
            InitializeComponent();
            PopulateEmailComboBox();
            comboBox_ShowDoctors.Visible = false;
            radioBtn_Doctor.Checked = true;
        }

        private void PopulateEmailComboBox()
        {
            comboBox_Email.SelectedIndex = 0;
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
            MessageBox.Show("If you are a nurse please select the name of the doctor that you will be working with from the list.", "Nurse Information");
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
            try
            {
               con.Open();
                string query = "select Nume,Prenume from dbo.Doctori";
                DataSet set;
                set = con.ExecuteDataSet(query);
              
                for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                {
                    string fullName = (set.Tables[0].Rows[i][0] + " " + set.Tables[0].Rows[i][1]);
                    if (comboBox_ShowDoctors.Items.Contains(fullName)) 
                    {
                    
                    }
                    else
                    {
                       comboBox_ShowDoctors.Items.Add(fullName);
                    }
                }
                comboBox_ShowDoctors.SelectedIndex = 0;
                con.Close();
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

        private void btn_ResetFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtBox_PhoneNr.Text = "Phone Number";
            txtBox_FirstName.Text = "First Name";
            txtBox_LastName.Text = "Last Name";
            txtBox_NIN.Text = "National Identification Number";
            txtBox_EmailAddress.Text = "Email Address";
            txtBox_SecurityCode.Text = "Security Code";
            txtBox_Username.Text = "Username";
            txtBox_Password.Text = "Password";
            txtBox_ConfirmPassword.Text = "Confirm Password";
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {

            if (radioBtn_Doctor.Checked)
            {
                try
                {
                    con.Open();
                    if (verifier.CheckName(txtBox_FirstName.Text) && verifier.CheckName(txtBox_LastName.Text) && verifier.CheckNIN(txtBox_NIN.Text) && verifier.CheckPhoneNumber(txtBox_PhoneNr.Text))                                 
                    {
                        con.ExecuteNonQuery("INSERT INTO dbo.Doctori VALUES ('" + Int64.Parse(txtBox_NIN.Text) + "','" + txtBox_LastName.Text + "','" + txtBox_FirstName.Text + "','" + txtBox_Username.Text + "','" + txtBox_EmailAddress.Text + "" + comboBox_Email.Text + "','" + txtBox_Password.Text + "','" + Int32.Parse(txtBox_PhoneNr.Text) + "','" + txtBox_SecurityCode.Text + "')");
                        ClearFields();
                        MessageBox.Show("The doctor has been added succesfully!!!");
                    }
                    else
                    {
                        MessageBox.Show("Wrong information format!");
                    }
                    con.Close();
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
            else if (radioBtn_Nurse.Checked)
            {
                try
                {
                    con.Open();
                    string[] DocFullName = (comboBox_ShowDoctors.Text).Split(' ');
                    SqlDataReader DocNameReader = con.ExecuteReader("Select CNP from dbo.Doctori where Nume='" + DocFullName[0] + "' AND Prenume='" + DocFullName[1] + "'");
                    while (DocNameReader.Read())
                    {
                        Doc_CNP = DocNameReader.GetInt64(0);
                    }

                    DocNameReader.Close();
                    if (verifier.CheckName(txtBox_FirstName.Text) && verifier.CheckName(txtBox_LastName.Text) && verifier.CheckNIN(txtBox_NIN.Text) && verifier.CheckPhoneNumber(txtBox_PhoneNr.Text))
                    {
                        con.ExecuteNonQuery("INSERT INTO dbo.Asistenti (CNP,CNP_Doctor,Nume,Prenume,Username,Email,Parola,Nr_Telefon,Security_Code) VALUES ('" + Int64.Parse(txtBox_NIN.Text) + "','"+Doc_CNP+"','" + txtBox_LastName.Text + "','" + txtBox_FirstName.Text + "','" + txtBox_Username.Text + "','" + txtBox_EmailAddress.Text + comboBox_Email.Text + "','" + txtBox_Password.Text + "','" + Int32.Parse(txtBox_PhoneNr.Text) + "','" + txtBox_SecurityCode.Text + "')");
                        ClearFields();
                        MessageBox.Show("The nurse has been added successfully!!!");
                    }
                    else
                    {
                        MessageBox.Show("Wrong information format!");
                    }
                    con.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Are you a nurse or a doctor? Please select your ocupation!!");
            }
        }

        private void PhoneNumber_Click(object sender, EventArgs e)
        {
            if (txtBox_PhoneNr.Text == "Phone Number")
            {
                txtBox_PhoneNr.Text = "";
            }
        }

        private void PhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txtBox_PhoneNr.Text == "")
            {
                txtBox_PhoneNr.Text = "Phone Number";
            }
        }

        private void NIN_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            Int64 a;
            if (Int64.TryParse(txtBox_NIN.Text, out a))
            {
                Int64 NIN = Int64.Parse(txtBox_NIN.Text);
                DataSet set;

                if (radioBtn_Doctor.Checked)
                {
                    string queryDoc = "SELECT * FROM dbo.Doctori where CNP='" + NIN + "'";
                    set = con.ExecuteDataSet(queryDoc);
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("The National Identification Number you introduced already exists!!!");
                        txtBox_NIN.Text = "National Identification Number";
                    }
                }
                else if (radioBtn_Nurse.Checked)
                {
                    string queryAsist = "SELECT * FROM dbo.Asistenti WHERE CNP='" + NIN + "' OR CNP_Doctor='" + NIN + "'";
                    set = con.ExecuteDataSet(queryAsist);
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("The National Identification Number you introduced already exists!!!");
                        txtBox_NIN.Text = "National Identification Number";
                    }
                }
            }
            con.Close();
        }
    }
}
