using ProiectII.UserControls;
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
    public partial class MainApp : Form
    {
        Int64 userCNP;
        char position;
        public MainApp(Int64 userCNP,char position)
        {
            InitializeComponent();
            this.userCNP = userCNP;
            this.position = position;
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            UC_VisualizeAllAppointments visualizeAllAppointments = new UC_VisualizeAllAppointments(userCNP,position);
            addControls(visualizeAllAppointments);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Up_Panel_Paint(object sender, PaintEventArgs e)
        {

        }



        #region User Controls
        private void addControls(UserControl uC)
        {
            Main_Panel.Controls.Clear();
            uC.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(uC);
            uC.BringToFront();
        }

        private void btn_VizitaCurenta_Click(object sender, EventArgs e)
        {
            UC_CurrentVisit currentVisit = new UC_CurrentVisit(userCNP, position);
            addControls(currentVisit);
        }

        #endregion

        private void btn_ToateProgramarile_Click(object sender, EventArgs e)
        {
            UC_VisualizeAllAppointments visualizeAllAppointments = new UC_VisualizeAllAppointments(userCNP, position);
            addControls(visualizeAllAppointments);
        }

        private void btn_CreazaProgramare_Click(object sender, EventArgs e)
        {
            UC_CreateNewAppointment createNewAppointment = new UC_CreateNewAppointment(userCNP, position);
            addControls(createNewAppointment);
        }

        private void btn_ModificaProgramare_Click(object sender, EventArgs e)
        {
            UC_ModifyExistingAppointment modifyExistingAppointment = new UC_ModifyExistingAppointment(userCNP, position);
            addControls(modifyExistingAppointment);
        }

        private void btn_SchimbariLogistice_Click(object sender, EventArgs e)
        {
            UC_LogisticalChanges logisticalChanges = new UC_LogisticalChanges(userCNP, position);
            addControls(logisticalChanges);
        }

        private void btn_CautaVizite_Click(object sender, EventArgs e)
        {
            UC_VisualizeAllVisits visualizeAllVisits = new UC_VisualizeAllVisits(userCNP, position);
            addControls(visualizeAllVisits);
        }

        private void btn_ModificaProgramare_Click_1(object sender, EventArgs e)
        {
            UC_ModifyExistingAppointment modifyExistingAppointment = new UC_ModifyExistingAppointment(userCNP, position);
            addControls(modifyExistingAppointment);
        }
    }
}
