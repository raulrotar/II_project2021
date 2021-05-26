using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProiectII.Forms
{
    
    public partial class ResetPasword : Form
    {
        Connection con = new Connection();
        public ResetPasword()
        {
            InitializeComponent();
        }

        private void ResetPasword_Load(object sender, EventArgs e)
        {
            emailComboBox.SelectedIndex = 0;
        }

        
        #region Insert Email TextBox
          private void IE_Click(object sender, MouseEventArgs e)
        {
            if (txtBox_InsertEmail.Text == "Insert Email")
            {
                txtBox_InsertEmail.Text = "";
            }

        }

        private void IE_Enter(object sender, EventArgs e)
        {
            if (txtBox_InsertEmail.Text == "Insert Email")
            {
                txtBox_InsertEmail.Text = "";
            }
        }

        private void IE_Leave(object sender, EventArgs e)
        {
            if (txtBox_InsertEmail.Text == "")
            {
                txtBox_InsertEmail.Text = "Insert Email";
            }
        }

        #endregion
         
        #region Security Code TextBox
        private void SQ_Leave(object sender, EventArgs e)
        {
            if (txtBox_SCode.Text == "")
            {
                txtBox_SCode.Text = "Security Code";
            }
        }

        private void SC_Click(object sender, MouseEventArgs e)
        {
            if (txtBox_SCode.Text == "Security Code")
            {
                txtBox_SCode.Text = "";
            }
        }

        private void SC_Enter(object sender, EventArgs e)
        {
            if (txtBox_SCode.Text == "Security Code")
            {
                txtBox_SCode.Text = "";
            }
        }


        #endregion

        #region Insert Password TextBox
        private void NP_Leave(object sender, EventArgs e)
        {
            if (txtBox_Password.Text == "")
            {
                txtBox_Password.Text = "New Password";
            }
        }
        private void NP_Click(object sender, MouseEventArgs e)
        {
            if (txtBox_Password.Text == "New Password")
            {
                txtBox_Password.Text = "";
            }
        }
        private void NP_Enter(object sender, EventArgs e)
        {
            if (txtBox_Password.Text == "New Password")
            {
                txtBox_Password.Text = "";
            }
        }


        #endregion

        #region Confirm Password TextBox
        private void CP_Enter(object sender, EventArgs e)
        {
            if (txtBox_ConfirmPassword.Text == "Confirm New Password")
            {
                txtBox_ConfirmPassword.Text = "";
            }
        }
        private void CP_Leave(object sender, EventArgs e)
        {
            if (txtBox_ConfirmPassword.Text == "")
            {
                txtBox_ConfirmPassword.Text = "Confirm New Password";
            }
        }

        private void CP_Click(object sender, MouseEventArgs e)
        {
            if (txtBox_ConfirmPassword.Text == "Confirm New Password")
            {
                txtBox_ConfirmPassword.Text = "";
            }
        }

        #endregion

        #region Password Cover
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtBox_Password.PasswordChar == '*')
            {
                txtBox_Password.PasswordChar = '\0';
            }
            else
            {
                txtBox_Password.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtBox_ConfirmPassword.PasswordChar == '*')
            {
                txtBox_ConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtBox_ConfirmPassword.PasswordChar = '*';
            }
        }

        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void btn_resetFields_Click_1(object sender, EventArgs e)
        {
            txtBox_InsertEmail.Text = "Insert Email";
            txtBox_SCode.Text = "Security Code";
            txtBox_Password.Text = "New Password";
            txtBox_ConfirmPassword.Text = "Confirm New Password";
            emailComboBox.SelectedIndex = 0;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            String mail = txtBox_InsertEmail.Text + emailComboBox.SelectedItem.ToString();
            String code = txtBox_SCode.Text;
            String email = "";
            String secCode = "";

            if (txtBox_InsertEmail.Text.Equals("Insert Email") || txtBox_SCode.Text.Equals("Security Code") || txtBox_Password.Text.Equals("New Password") || txtBox_ConfirmPassword.Text.Equals("Confirm New Password"))
            {
                MessageBox.Show("Please fill in all the fields!");
            }
            else
            {
                try
                {
                    con.Open();
                    string query_mail_doctors = "SELECT Email FROM dbo.Doctori WHERE Email='" + mail + "'";
                    string query_mail_asist = "SELECT Email FROM dbo.Asistenti WHERE Email='" + mail + "'";
                    string query_securityCode_doctors = "SELECT Security_Code From dbo.Doctori WHERE Security_Code='" + code + "'";
                    string query_securityCode_asist = "SELECT Security_Code From dbo.Asistenti WHERE Security_Code='" + code + "'";
                    string query_updatePass_doctors = "UPDATE dbo.Doctori SET Parola ='" + txtBox_Password.Text + "' WHERE Email = '" + txtBox_InsertEmail.Text + emailComboBox.SelectedItem + "'";
                    string query_updatePass_asist = "UPDATE dbo.Asistenti SET Parola ='" + txtBox_Password.Text + "' WHERE Email = '" + txtBox_InsertEmail.Text + emailComboBox.SelectedItem + "'";

                    SqlDataReader row;
                    SqlDataReader row2;
                    row = con.ExecuteReader(query_mail_doctors);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            email = row["Email"].ToString();
                        }

                        if (mail.Equals(email))
                        {
                            row.Close();
                            row = con.ExecuteReader(query_securityCode_doctors);
                            if (row.HasRows)
                            {
                                while (row.Read())
                                {
                                    secCode = row["Security_Code"].ToString();
                                }
                                if (code.Equals(secCode))
                                {
                                    if (txtBox_Password.Text.Equals(txtBox_ConfirmPassword.Text))
                                    {
                                        row.Close();
                                        con.ExecuteNonQuery(query_updatePass_doctors);
                                        MessageBox.Show("Password successfully updated!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Password and Confirm Password values have to be the same!");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Security Code!");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid email");
                        }
                        row.Close();
                    }
                    else
                    {
                        row.Close();
                        row2 = con.ExecuteReader(query_mail_asist);
                        if (row2.HasRows)
                        {
                            while (row2.Read())
                            {
                                email = row2["Email"].ToString();
                            }

                            if (mail.Equals(email))
                            {
                                row2.Close();
                                row2 = con.ExecuteReader(query_securityCode_asist);
                                if (row2.HasRows)
                                {
                                    while (row2.Read())
                                    {
                                        secCode = row2["Security_Code"].ToString();
                                    }
                                    if (code.Equals(secCode))
                                    {
                                        if (txtBox_Password.Text.Equals(txtBox_ConfirmPassword.Text))
                                        {
                                            row2.Close();
                                            con.ExecuteNonQuery(query_updatePass_asist);
                                            MessageBox.Show("Password updated successfully!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Password and Confirm Password values have to be the same!");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Security Code!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email");
                        }
                        row2.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error!", "Information");
                }

                con.Close();
            }
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            toolTip1.Show("The Security code chosen when the account was created!",pictureBox7);
        }

        private void txtBox_Password_TextChanged(object sender, EventArgs e)
        {
            txtBox_Password.PasswordChar = '*';
        }

        private void txtBox_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            txtBox_ConfirmPassword.PasswordChar = '*';
        }
    }
}
