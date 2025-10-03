using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Driving_Licence
{
    public partial class frmLicenseHistory : Form
    {
        int DrivingID = 0;
        public frmLicenseHistory(int ID)
        {
            InitializeComponent();
            DrivingID = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            lblRecord.Text = dgLicense.RowCount.ToString();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDriverLicenseInfo frm = new frmDriverLicenseInfo((int)dgLicense.CurrentRow.Cells[0].Value);
            frm.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(Convert.ToInt32((int)dgLicense.CurrentRow.Cells[0].Value));
            frm.Show();
        }
    }
}
