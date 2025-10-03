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
using static ClassBusinesLayerDrivingLicense.MyLicense;

namespace Projet_Driving_Licence
{
    public partial class cntr_Detain_License : UserControl
    {
        public cntr_Detain_License()
        {
            InitializeComponent();
        }

        public void Fill_Detain_Info()
        {
            frm_Detain_License fm = Application.OpenForms.OfType<frm_Detain_License>().FirstOrDefault();
            DetainLicense detain = DetainLicense.FindDetain_License(Convert.ToInt32(fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));

           

            if (detain== null)
            {
                lblDetainID.Text = "????";
               lblDetainDate.Text = DateTime.Now.ToString();
               lblCreatedBy.Text = clsGlobal.name;
                lblLicenseID.Text = fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text;
            }
            else
            {
                lblDetainID.Text = detain.DetainID.ToString();
                lblDetainDate.Text = detain.DetainDate.ToString();
                lblCreatedBy.Text = Users.Find(detain.CreatedByUserID).UserName;
                lblLicenseID.Text = detain.LicenseID.ToString();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
