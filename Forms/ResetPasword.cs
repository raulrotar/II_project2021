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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            using (LoginForm lf = new LoginForm())
            {
                lf.ShowDialog();
                                this.Close();
            }
        }
    }
}
