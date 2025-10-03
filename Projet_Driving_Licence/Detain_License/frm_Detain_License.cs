using ClassBusinesLayerDrivingLicense;
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
    public partial class frm_Detain_License : Form
    {
        
        public frm_Detain_License()
        {
            InitializeComponent();
           
        }

        private void frm_Detain_License_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));

            frm.contrPersonInfo1.LoadMy_data(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblNationalNo.Text);

            MyLicense license = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));
            string ClassName = LicenseClasses.FindApplicationClassWithID(license.LicenseClass).LicenseClassName;

            DataTable dt = MyLicense.Get_AllLicenses(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblDriverID.Text));
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
        }

        private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));
            frm.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));
            frm.Show();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            DetainLicense detain = new DetainLicense();
            

            MyLicense license = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));


            detain.LicenseID = Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text);
            detain.DetainDate = DateTime.Now;
            detain.FineFees = Convert.ToDecimal(cntr_Detain_License1.txtFees.Text);
            detain.CreatedByUserID =Users.FindUserByName(clsGlobal.name).UserID;
            detain.IsReleased = 0;
            detain.ReleaseDate = DateTime.Now;
               
            
            detain.ReleasedByUserID = null;
            detain.ReleasedApplicationID = null; 

            if(detain.Save())
            {
                MessageBox.Show("License Detained successffully whth ID= " +  detain.DetainID);
                cntr_Detain_License1.lblDetainID.Text = detain.DetainID.ToString();
                btnDetain.Enabled = false;
                linkShowLicenseInfo.Enabled = true;
            }

        }
    }
}
