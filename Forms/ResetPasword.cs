using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectII.Forms
{
    public partial class ResetPasword : Form
    {
        public ResetPasword()
        {
            InitializeComponent();
        }

        
      

        private void ResetPasword_Load(object sender, EventArgs e)
        {

        }

        
        #region Insert Email TextBox
          private void IE_Click(object sender, MouseEventArgs e)
        {
            if (txtBox_InsertEmail.Text == "someone@example.com")
            {
                txtBox_InsertEmail.Text = "";
            }

        }

        private void IE_Enter(object sender, EventArgs e)
        {
            if (txtBox_InsertEmail.Text == "someone@example.com")
            {
                txtBox_InsertEmail.Text = "";
            }
        }

        private void IE_Leave(object sender, EventArgs e)
        {
            if (txtBox_InsertEmail.Text == "")
            {
                txtBox_InsertEmail.Text = "someone@example.com";
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
                txtBox_Password.Text = "Password";
            }
        }
        private void NP_Click(object sender, MouseEventArgs e)
        {
            if (txtBox_Password.Text == "Password")
            {
                txtBox_Password.Text = "";
            }
        }
        private void NP_Enter(object sender, EventArgs e)
        {
            if (txtBox_Password.Text == "Password")
            {
                txtBox_Password.Text = "";
            }
        }


        #endregion

        #region Confirm Password TextBox
        private void CP_Enter(object sender, EventArgs e)
        {
            if (txtBox_ConfirmPassword.Text == "Confirm Password")
            {
                txtBox_ConfirmPassword.Text = "";
            }
        }
        private void CP_Leave(object sender, EventArgs e)
        {
            if (txtBox_ConfirmPassword.Text == "")
            {
                txtBox_ConfirmPassword.Text = "Confirm Password";
            }
        }

        private void CP_Click(object sender, MouseEventArgs e)
        {
            if (txtBox_ConfirmPassword.Text == "Confirm Password")
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

        

        private void txtBox_InsertEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_resetFields_Click_1(object sender, EventArgs e)
        {
            txtBox_InsertEmail.Text = "someone@example.com";
            txtBox_SCode.Text = "Security Code";
            txtBox_Password.Text = "Password";
            txtBox_ConfirmPassword.Text = "Confirm Password";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
