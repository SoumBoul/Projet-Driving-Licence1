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
    public partial class cntrDetainInfo_For_frmRelease : UserControl
    {
        public cntrDetainInfo_For_frmRelease()
        {
            InitializeComponent();
        }


        public void Fill_Detain_Info()
        {
            frmRelease_Detained_License fm = Application.OpenForms.OfType<frmRelease_Detained_License>().FirstOrDefault();
            DetainLicense detain = DetainLicense.FindDetain_License(Convert.ToInt32(fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));
           
           if(detain==null )
           {
                lblDetainID.Text = detain.DetainID.ToString();
                lblDetainDate.Text = detain.DetainDate.ToString();
                lblCreatedBy.Text = clsGlobal.name;
                lblLicenseID.Text = detain.LicenseID.ToString();
                lblFineFees.Text = detain.FineFees.ToString();
                lblApplicationFees.Text = AppTypes.FindApplicationTypesWithTitle(fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblIssueReason.Text).ApplicationFees.ToString();
                lblTotalFees.Text = (detain.FineFees + AppTypes.FindApplicationTypesWithTitle(fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblIssueReason.Text).ApplicationFees).ToString();
                lblReleasedID.Text = detain.ReleasedApplicationID.ToString();
            }

           else
            {
                lblDetainID.Text = detain.DetainID.ToString();
                lblDetainDate.Text = detain.DetainDate.ToString();
                lblCreatedBy.Text = Users.Find(detain.CreatedByUserID).UserName;
                lblLicenseID.Text = detain.LicenseID.ToString();
                lblFineFees.Text = detain.FineFees.ToString();
                lblApplicationFees.Text = AppTypes.FindApplicationTypesWithTitle(fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblIssueReason.Text).ApplicationFees.ToString();
                lblTotalFees.Text = (detain.FineFees + AppTypes.FindApplicationTypesWithTitle(fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblIssueReason.Text).ApplicationFees).ToString();
                lblReleasedID.Text = detain.ReleasedApplicationID.ToString();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
