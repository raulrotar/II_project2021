using ProiectII.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProiectII
{
    public partial class LoginForm : Form
    {
        Connection connection = new Connection();
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
            if (txtBox_UserName.Text == "User Name")
            {
                txtBox_UserName.Text = "";
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (txtBox_UserName.Text == "")
            {
                txtBox_UserName.Text = "User Name";
            }
        }

          private void UserName_Click(object sender, EventArgs e)
        {
            if (txtBox_UserName.Text == "User Name")
            {
                txtBox_UserName.Text = "";
            }
        }

        private void UserName_Click(object sender, MouseEventArgs e)
        {
            if (txtBox_UserName.Text == "User Name")
            {
                txtBox_UserName.Text = "";
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
            String txt_Username = txtBox_UserName.Text;
            String txt_Password = txtBox_Password.Text;
            String username= "";
            String password="";
            Int64 userCNP = new Int64();

            if ((txt_Username == "User Name") || (txt_Password == "Password"))
            {
                error_Msg.Text = "Please insert custom values!";
            } else if ((txt_Username == "") || (txt_Password == ""))
            {
                error_Msg.Text = "Empty field!";
            } else if (txt_Username.ElementAt(0) == ' ')
            {
                error_Msg.Text = "Do not use blank spaces!";
            }
            
            else
            {
                error_Msg.Text = "";
                try
                {
                    connection.Open();
                    string query_doctors = "SELECT Username,Parola,CNP FROM dbo.Doctori WHERE Username='" + txt_Username + "' AND Parola ='" + txt_Password + "'";
                    string query_asist = "SELECT Username,Parola,CNP FROM dbo.Asistenti WHERE Username='"+txt_Username+"' AND Parola='"+txt_Password+"'";
                    SqlDataReader row,row2;
                    row = connection.ExecuteReader(query_doctors);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            username = row["Username"].ToString();
                            password = row["Parola"].ToString();
                            userCNP = Int64.Parse(row["CNP"].ToString());
                        }
                        if ((txt_Username.Equals(username))&&(txt_Password.Equals(password))) {
                            using (MainApp main = new MainApp(userCNP,'d'))
                            {
                                this.Hide();
                                main.ShowDialog();
                                this.Close();
                            } 
                        }
                        row.Close();
                    }
                    else
                    {
                        row.Close();
                        row2 = connection.ExecuteReader(query_asist);
                        if(row2.HasRows)
                        {
                            while(row2.Read())
                            {
                                username = row2["Username"].ToString();
                                password = row2["Parola"].ToString();
                                userCNP = Int64.Parse(row2["CNP"].ToString());
                            }
                            if((txt_Username.Equals(username))&&(txt_Password.Equals(password)))
                            {
                                using (MainApp main = new MainApp(userCNP,'a'))
                                {
                                    this.Hide();
                                    main.ShowDialog();
                                    this.Close();
                                }
                            }
                            row2.Close();
                        }
                        else
                        {
                            row2.Close();
                            error_Msg.Text = "Credentials not found!";
                        }
                        
                    }


                    connection.Close();
                }
                catch(Exception )
                {
                    MessageBox.Show("Connection Error!","Information");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_Password_TextChanged_1(object sender, EventArgs e)
        {
            txtBox_Password.PasswordChar = '*';
        }
    }
}
