using System;
using ClassBusinesLayerDrivingLicense;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Xml.Linq;

namespace Projet_Driving_Licence
{
    public partial class frm_List_Detained_License : Form
    {
        public frm_List_Detained_License()
        {
            InitializeComponent();
        }

        private void frm_List_Detained_License_Load(object sender, EventArgs e)
        {
            dgDetainLicense.DataSource = DetainLicense.Get_List_Detained_License();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmRelease_Detained_License frm = new frmRelease_Detained_License();
            frm.ShowDialog();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frm_Detain_License frm = new frm_Detain_License();
            frm.ShowDialog();

        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)dgDetainLicense.CurrentRow.Cells[8].Value);

            frm.contrPersonInfo1.LoadMy_data((string)dgDetainLicense.CurrentRow.Cells[6].Value);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo((int)dgDetainLicense.CurrentRow.Cells[1].Value);
            frm.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info((int)dgDetainLicense.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showLicensePersonHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory((int)dgDetainLicense.CurrentRow.Cells[1].Value);
            frm.contrPersonInfo1.LoadMy_data((string)dgDetainLicense.CurrentRow.Cells[6].Value);
          

           

            MyLicense license = MyLicense.FindLicenseWith_LicenseID((int)dgDetainLicense.CurrentRow.Cells[1].Value);
            string ClassName = LicenseClasses.FindApplicationClassWithID(license.LicenseClass).LicenseClassName;

            DataTable dt = MyLicense.Get_AllLicenses(license.DriverID);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    frm.dgLicense.Rows.Add(row["LicenseID"], row["ApplicationID"], ClassName, row["IssueDate"],
                 row["ExpirationDate"], row["IsActive"]);
                }
            }

            InternationalLicense international = InternationalLicense.Find_International_License(license.LicenseID);


            if (international != null)
            {
                frm.dg_int_License.Rows.Add(international.InternationalLicenseID, international.ApplicationID, international.IssuedUsingLocalLicenseID, international.IssueDate, international.ExpirationDate, international.IsActive,
            license.ExpirationDate, license.IsActive);
            }

            frm.ShowDialog();

            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelease_Detained_License frm = new frmRelease_Detained_License();
            frm.cntr_InternationalLicenseApplication1.txtLicenseID.Text = dgDetainLicense.CurrentRow.Cells[1].Value.ToString();
            frm.cntr_InternationalLicenseApplication1.groupBox1.Enabled = false;
            frm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info((int)dgDetainLicense.CurrentRow.Cells[1].Value);

            DetainLicense detain = DetainLicense.FindDetain_License((int)dgDetainLicense.CurrentRow.Cells[1].Value);
            if (detain == null)
            {
                frm.cntrDetainInfo_For_frmRelease1.lblDetainID.Text = detain.DetainID.ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblDetainDate.Text = detain.DetainDate.ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblCreatedBy.Text = clsGlobal.name;
                frm.cntrDetainInfo_For_frmRelease1.lblLicenseID.Text = detain.LicenseID.ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblFineFees.Text = detain.FineFees.ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblApplicationFees.Text = AppTypes.FindApplicationTypesWithTitle(frm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblIssueReason.Text).ApplicationFees.ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblTotalFees.Text = (detain.FineFees + AppTypes.FindApplicationTypesWithTitle(frm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblIssueReason.Text).ApplicationFees).ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblReleasedID.Text = detain.ReleasedApplicationID.ToString();
            }

            else
            {
                frm.cntrDetainInfo_For_frmRelease1.lblDetainID.Text = detain.DetainID.ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblDetainDate.Text = detain.DetainDate.ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblCreatedBy.Text = Users.Find(detain.CreatedByUserID).UserName;
                frm.cntrDetainInfo_For_frmRelease1.lblLicenseID.Text = detain.LicenseID.ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblFineFees.Text = detain.FineFees.ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblApplicationFees.Text = AppTypes.FindApplicationTypesWithTitle(frm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblIssueReason.Text).ApplicationFees.ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblTotalFees.Text = (detain.FineFees + AppTypes.FindApplicationTypesWithTitle(frm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblIssueReason.Text).ApplicationFees).ToString();
                frm.cntrDetainInfo_For_frmRelease1.lblReleasedID.Text = detain.ReleasedApplicationID.ToString();
            }
           
           

            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DetainLicense detain = DetainLicense.FindDetain_License((int)dgDetainLicense.CurrentRow.Cells[1].Value);

            if (detain.IsReleased == 1)
            {
                this.releaseDetainedLicenseToolStripMenuItem.Enabled = false;
            }
            else
                this.releaseDetainedLicenseToolStripMenuItem.Enabled = true; 

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != -1)
            {
                txtFilterBy.Visible = true;

            }
        }

        public void Filter(string name)
        {

            DataTable dt = DetainLicense.Get_List_Detained_License();
            DataView dv = new DataView(dt);

            if (cbFilter.Text == "DetainID" && txtFilterBy.Text == name && name != "")
            {

                dv.RowFilter = $"DetainID= '{name}'";

                dgDetainLicense.DataSource = dv;
                dgDetainLicense.Show();
                return;

            }
            else if (cbFilter.Text == "LicenseID" && txtFilterBy.Text == name && name != "")
            {

                dv.RowFilter = $"LicenseID= '{name}'";

                dgDetainLicense.DataSource = dv;
                dgDetainLicense.Show();
                return;
            }
            else if (cbFilter.Text == "LicenseID" && txtFilterBy.Text == name && name != "")
            {

                dv.RowFilter = $"LicenseID= '{name}'";

                dgDetainLicense.DataSource = dv;
                dgDetainLicense.Show();
                return;
            }
            else if (cbFilter.Text == "DetainDate" && txtFilterBy.Text == name && name != "")
            {

                dv.RowFilter = $"DetainDate= '{name}'";

                dgDetainLicense.DataSource = dv;
                dgDetainLicense.Show();
                return;
            }
            else if (cbFilter.Text == "IsReleased" && txtFilterBy.Text == name && name != "")
            {

                dv.RowFilter = $"IsReleased= '{name}'";

                dgDetainLicense.DataSource = dv;
                dgDetainLicense.Show();
                return;
            }
            else if (cbFilter.Text == "FineFees" && txtFilterBy.Text == name && name != "")
            {

                dv.RowFilter = $"FineFees= '{name}'";

                dgDetainLicense.DataSource = dv;
                dgDetainLicense.Show();
                return;
            }
            else if (cbFilter.Text == "NationalNo" && txtFilterBy.Text == name && name != "")
            {

                dv.RowFilter = $"NationalNo= '{name}'";

                dgDetainLicense.DataSource = dv;
                dgDetainLicense.Show();
                return;
            }
           
            else
            {
                dgDetainLicense.DataSource = DetainLicense.Get_List_Detained_License();
                dgDetainLicense.Show();
            }


        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            Filter(txtFilterBy.Text);

        }
    }
}
