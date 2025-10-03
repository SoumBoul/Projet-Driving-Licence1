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
    public partial class cntrApp_Info_For_Replacement_License : UserControl
    {
        public cntrApp_Info_For_Replacement_License()
        {
            InitializeComponent();
        }

        public void Fill_Data()
        {
            frmRemplacementForDamageLicense fm = Application.OpenForms.OfType<frmRemplacementForDamageLicense>().FirstOrDefault();
            MyLicense license = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));

            App app = App.FindApplicationWithID(license.ApplicationID);
            
            lblApplicationDate.Text = app.ApplicationDate.ToString();
            if(fm.RBDamage.Checked)
            {
                lblApplicationFees.Text = AppTypes.FindApplicationTypes(4).ApplicationFees.ToString();
            }
            else if(fm.RBLost.Checked)
            {
                lblApplicationFees.Text = AppTypes.FindApplicationTypes(3).ApplicationFees.ToString();
            }
            lblOld_LicenseID.Text = license.LicenseID.ToString();

            lblCreatedBy.Text = clsGlobal.name;

           
            this.Show();
            }
        private void cntrApp_Info_For_Replacement_License_Load(object sender, EventArgs e)
        {
           


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
