using System;
using ClassBusinesLayerDrivingLicense;
using System.Windows.Forms;
using System.Linq;

namespace Projet_Driving_Licence
{
    public partial class cntr_Drver_Int_License_Info : UserControl
    {
        public cntr_Drver_Int_License_Info()
        {
            InitializeComponent();
        }

       public void Fill_Driver_License_Info(int LicenseID)
        {
            frmInternationalLicenseApplication fm = Application.OpenForms.OfType<frmInternationalLicenseApplication>().FirstOrDefault();
            InternationalLicense international = InternationalLicense.Find_Driver_International_License_Info(LicenseID);
            if (international== null)
            {
                international = InternationalLicense.Find_Driver_International_License_Info(Convert.ToInt32(fm.cntr_InternationalLicenseApplication1.lblLicenseID.Text));
                
            }
            lblName.Text =international.FirstName+" " + international.SecondName+" "+ international.ThirdName+ " " + international.LastName;
            lbl_Int_LicenseID.Text = international.InternationalLicenseID.ToString();
            lblLicenseID.Text = international.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = international.NationalNo.ToString();
             
            if(international.Gendor ==false)
            {
                lblGendor.Text = "Male";
            }
            else
            {
                lblGendor.Text = "Female";
            }

            lblIssueDate.Text = international.IssueDate.ToString();
            lblApplicationID.Text = international.ApplicationID.ToString();

            if(international.IsActive== false)
            { 
                lblIsActive.Text = "Yes"; 
            }
            else
            {
                lblIsActive.Text = "NO";
            }
            lblDateOfBirth.Text = international.DateOfBirth.ToString();
            lblDriverID.Text = international.DriverID.ToString();
            lblExpirationDate.Text = international.ExpirationDate.ToString();




        }
        private void cntr_Drver_Int_License_Info_Load(object sender, EventArgs e)
        {




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cntr_Drver_Int_License_Info_Load_1(object sender, EventArgs e)
        {

        }
    }
}
