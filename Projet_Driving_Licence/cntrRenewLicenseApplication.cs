using System;
using ClassBusinesLayerDrivingLicense;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Linq;
using System.ComponentModel;

namespace Projet_Driving_Licence
{
    public partial class cntrRenewLicenseApplication : UserControl
    {
        clsGlobal global = new clsGlobal();
        public cntrRenewLicenseApplication()
        {
            InitializeComponent();
        }

        public void Fill_Renew_License_Application(int licenseID)
        {
            frm_Renew_License_Application fm = Application.OpenForms.OfType<frm_Renew_License_Application>().FirstOrDefault();
            App app = App.FindApplicationWithNationalNo(fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblNationalNo.Text);
            
            MyLicense license1 = MyLicense.FindLicenseWith_LicenseID(licenseID);
            MyLicense license = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(fm.cntr_InternationalLicenseApplication1.txtLicenseID.Text));
            //int dt = (license1.ExpirationDate.Day + license1.ExpirationDate.Month + license1.ExpirationDate.Year);//this calcul for to calculate the total of Expiration Date
            //int dt2=(DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year);
            int year = LicenseClasses.FindApplicationClassWithID_Validity_Length(license.LicenseClass).DefaultValidityLength;
            if ( DateTime.Now<= license.ExpirationDate )
            {
              
                lblR_L_ApplicationID.Text = license.ApplicationID.ToString();
                lblRenewedLicenseID.Text = license.LicenseID.ToString();

                lblApplicationDate.Text = app.AppDate.ToString();
                lblIssueDate.Text = app.AppDate.ToString(); 
                lblApplicationFees.Text = AppTypes.FindApplicationTypes(license.LicenseClass).ApplicationFees.ToString();
                lblLicenseFees.Text = license.PaidFees.ToString();
                lblNotes.Text = license.Notes.ToString();
                lblOld_LicenseID.Text = license.LicenseID.ToString();
                lblExpirationDate.Text = license.ExpirationDate.ToString();
                
                lblCreatedBy.Text = clsGlobal.name;
                lblTotalFees.Text = (license.PaidFees + Convert.ToDecimal(lblApplicationFees.Text)).ToString();

                this.Show();

            }
            else
            {
                //MyLicense license = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(fm.cntr_InternationalLicenseApplication1.txtLicenseID.Text));

                lblR_L_ApplicationID.Text = "????";
                lblRenewedLicenseID.Text = "????";

                lblApplicationDate.Text = DateTime.Now.ToString();
                
                lblIssueDate.Text = DateTime.Now.ToString(); ;
                lblApplicationFees.Text = AppTypes.FindApplicationTypes(license.LicenseClass).ApplicationFees.ToString();
                lblLicenseFees.Text = license.PaidFees.ToString();
                lblNotes.Text = license.Notes.ToString();
                lblOld_LicenseID.Text = license.LicenseID.ToString();
                if (license.ExpirationDate.Month <= 9 && license.ExpirationDate.Day <= 9)
                {
                    lblExpirationDate.Text = ("0") + (license.ExpirationDate.Day +1 ) + "/" + "0" + (license.ExpirationDate.Month) + "/" + (license.ExpirationDate.Year +year);
                }
                else
                {
                    lblExpirationDate.Text = (license.ExpirationDate.Day +1) + "/" + (license.ExpirationDate.Month) + "/" + (license.ExpirationDate.Year +year );
                }
                lblCreatedBy.Text = clsGlobal.name;
                lblTotalFees.Text = (license.PaidFees +Convert.ToDecimal(lblApplicationFees.Text)).ToString();

                

                this.Show();

            }
            if(license.IsActive== true)
            { 
               
            }
            else
            {
                
            }



        }

        private void cntrRenewLicenseApplication_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
