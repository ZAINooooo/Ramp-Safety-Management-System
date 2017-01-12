using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace piac_project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pbxPersonInfo_Click(object sender, EventArgs e)
        {
            frmPersonalInfo pi = new frmPersonalInfo();
            pi.ShowDialog();

            


        }

        private void pbxMedical_Click(object sender, EventArgs e)
        {
            MEDICAL2 m = new MEDICAL2();
            m.ShowDialog();

        }

        private void pbxRampSafety_Click(object sender, EventArgs e)
        {
            RampSafety2 pl = new RampSafety2();
            pl.ShowDialog();

        }

        private void pbxSafetyVio_Click(object sender, EventArgs e)
        {
            safetyViolation2 sv = new safetyViolation2();
            sv.ShowDialog();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            details2 dtl = new details2();
            dtl.ShowDialog();
        }

        
    }
}
