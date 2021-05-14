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
    public partial class UC_ModifyExistingAppointment : UserControl
    {
        public UC_ModifyExistingAppointment()
        {
            InitializeComponent();
        }

        private void UC_ModifyExistingAppointment_Load(object sender, EventArgs e)
        {
            comboBox_SearchBy.SelectedIndex = 0;
            comboBox_Email.SelectedIndex = 0;
        }
    }
}
