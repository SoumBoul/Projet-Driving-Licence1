using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassBusinesLayerDrivingLicense;

namespace Projet_Driving_Licence
{
    public partial class frmGet_All_International_Licenses_Applications : Form
    {
        public frmGet_All_International_Licenses_Applications()
        {
            InitializeComponent();
        }

        private void frmGet_All_International_Licenses_Applications_Load(object sender, EventArgs e)
        {
            dg_GetAll_International_Licenses.DataSource = InternationalLicense.GetAll_International_Licenses();

            dg_GetAll_International_Licenses.Show();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App app = App.FindApplicationWithID((int)dg_GetAll_International_Licenses.CurrentRow.Cells[1].Value);
            frmPersonDetails frm = new frmPersonDetails(app.ApplicationPersonID);
            frm.Show();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyLicense license = MyLicense.FindLicenseWith_LicenseID((int)dg_GetAll_International_Licenses.CurrentRow.Cells[3].Value);
            App app = App.FindApplicationWithID(license.ApplicationID);
            InternationalLicense international = InternationalLicense.Find_Driver_International_License_Info((int)dg_GetAll_International_Licenses.CurrentRow.Cells[0].Value);
            frmLicenseHistory frm = new frmLicenseHistory(license.ApplicationID);
            contrPersonInfo cntr = new contrPersonInfo();
            frm.contrPersonInfo1.LoadMy_data(international.NationalNo);



             frm.dgLicense.Rows.Add(license.LicenseID, license.ApplicationID, LicenseClasses.FindApplicationClassWithID(license.LicenseClass).LicenseClassName, license.IssueReason,
           license.ExpirationDate, license.IsActive);

           

            if (international != null)
            {
                frm.dg_int_License.Rows.Add(international.InternationalLicenseID, international.ApplicationID, international.IssuedUsingLocalLicenseID, international.IssueDate, international.ExpirationDate, international.IsActive,
            license.ExpirationDate, license.IsActive);
            }



            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Driver_International_LicenseInfo frm = new frm_Driver_International_LicenseInfo((int)dg_GetAll_International_Licenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }
    }
}
