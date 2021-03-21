using ProiectII.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectII
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (ResetPasword rp= new ResetPasword())
            {
                rp.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (AddNewUser nu = new AddNewUser())
            {
                nu.ShowDialog();

            }
        }

        private void txtBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginGB_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtBox_Password.PasswordChar == '*') 
            {
                txtBox_Password.PasswordChar = '\0';
            }else
            {
                txtBox_Password.PasswordChar = '*';
            }
            
        }

      
        
        #region UserName TextBox
          private void UserName_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Name")
            {
                textBox1.Text = "";
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "User Name";
            }
        }

          private void UserName_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Name")
            {
                textBox1.Text = "";
            }
        }

        private void UserName_Click(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "User Name")
            {
                textBox1.Text = "";
            }
        }
        #endregion

        #region Password TextBox
          private void Password_Leave(object sender, EventArgs e)
        {
            if (txtBox_Password.Text == "")
            {
                txtBox_Password.Text = "Password";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (txtBox_Password.Text == "Password")
            {
                txtBox_Password.Text = "";
            }
        }
        private void Password_Click(object sender, MouseEventArgs e)
        {
            if (txtBox_Password.Text == "Password")
            {
                txtBox_Password.Text = "";
            }
        }


        #endregion

        private void btn_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
