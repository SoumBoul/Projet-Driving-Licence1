using ClassBusinesLayerDrivingLicense;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;

namespace Projet_Driving_Licence
{
    public partial class cntr_InternationalLicenseApplication : UserControl
    {
        clsGlobal global = new clsGlobal();
        public cntr_InternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isInternationalActive = Application.OpenForms.OfType<frmInternationalLicenseApplication>().Any();
            bool isRenewActive = Application.OpenForms.OfType<frm_Renew_License_Application>().Any();

            bool isReplacementDamage= Application.OpenForms.OfType<frmRemplacementForDamageLicense>().Any();

            bool isDetainLisence= Application.OpenForms.OfType<frm_Detain_License>().Any();
            bool isReleased = Application.OpenForms.OfType<frmRelease_Detained_License>().Any();

           
            cntrDriverLiceseInfo1 cntr = new cntrDriverLiceseInfo1();
            if(txtLicenseID.Text== "")
            {
                return;

            }

            this.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(Convert.ToInt32(txtLicenseID.Text));

            MyLicense license = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(txtLicenseID.Text));
           
            if (license==null)
            {
                return;
            }
            App type = App.FindApplicationWithID(license.ApplicationID);
            
            AppTypes app = AppTypes.FindApplicationTypes(type.ApplicationTypeID);

            InternationalLicense international = InternationalLicense.Find_International_License(license.LicenseID);
            if (international != null)
            {
                lblApplicationID.Text = international.ApplicationID.ToString();
                lblLicenseID.Text = international.InternationalLicenseID.ToString();
            }
            else
            {
                lblApplicationID.Text = "???";
                lblLicenseID.Text = "???";
                
               
            }
            
            if(license.IsActive == false && isRenewActive==true  )
            {
                MessageBox.Show("This License in NOT Active ", "Not Allowed", MessageBoxButtons.OK);
                frm_Renew_License_Application fm = Application.OpenForms.OfType<frm_Renew_License_Application>().FirstOrDefault();
                fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                fm.btnRenew.Enabled = false;
                fm.linkShowLicenseInfo.Enabled = true;

                return;
            }
            if(license.IsActive==false && isReplacementDamage == true )
            {
                MessageBox.Show("This License in NOT Active ", "Not Allowed", MessageBoxButtons.OK);
                frmRemplacementForDamageLicense fm = Application.OpenForms.OfType<frmRemplacementForDamageLicense>().FirstOrDefault();
                fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                fm.cntrApp_Info_For_Replacement_License1.Fill_Data();
                fm.btnIssueReplacement.Enabled = false;
                fm.linkShowLicenseInfo.Enabled = true;
                return;


            }
            if (license.IsActive == false &&  isDetainLisence== true)
                {
                   // MessageBox.Show("This License in NOT Active ", "Not Allowed", MessageBoxButtons.OK);
                    frm_Detain_License fm = Application.OpenForms.OfType<frm_Detain_License>().FirstOrDefault();
                    fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                    fm.cntr_Detain_License1.Fill_Detain_Info();
                    fm.btnDetain.Enabled = true;
                    fm.linkShowLicenseInfo.Enabled = true;

                return;

                }
            DetainLicense detain = DetainLicense.FindDetain_License(license.LicenseID);
            
            if (detain==null &&  isReleased == true)
            {
                MessageBox.Show("Selected License is not Detained, Choose another one", "Not Allowed", MessageBoxButtons.OK);
                frmRelease_Detained_License fm = Application.OpenForms.OfType<frmRelease_Detained_License>().FirstOrDefault();
                fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
               
                fm.btnRelease.Enabled = false;
                fm.linkShowLicenseInfo.Enabled = true;

                return;

            }

            if (detain != null && isDetainLisence == true && detain.IsReleased== 1)
            {
                MessageBox.Show("Selected License is  Detained, Choose another one", "Not Allowed", MessageBoxButtons.OK);
                frm_Detain_License fm = Application.OpenForms.OfType<frm_Detain_License>().FirstOrDefault();
                fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                fm.cntr_Detain_License1.Fill_Detain_Info();

                fm.btnDetain.Enabled = false;
                fm.linkShowLicenseInfo.Enabled = true;

                return;

            }

            if (detain != null && isDetainLisence == true && detain.IsReleased == 0)
            {
                
                frm_Detain_License fm = Application.OpenForms.OfType<frm_Detain_License>().FirstOrDefault();
                fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                fm.cntr_Detain_License1.Fill_Detain_Info();

                fm.btnDetain.Enabled = true;
                fm.linkShowLicenseInfo.Enabled = true;

                return;

            }
            if (detain != null && isReleased == true && detain.IsReleased==0)
            {
                
                frmRelease_Detained_License fm = Application.OpenForms.OfType<frmRelease_Detained_License>().FirstOrDefault();
                fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                fm.cntrDetainInfo_For_frmRelease1.Fill_Detain_Info();

                fm.btnRelease.Enabled = true;
                fm.linkShowLicenseInfo.Enabled = true;

                return;

            }
            if (detain != null && isReleased == true && detain.IsReleased == 1)
            {

                frmRelease_Detained_License fm = Application.OpenForms.OfType<frmRelease_Detained_License>().FirstOrDefault();
                fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                fm.cntrDetainInfo_For_frmRelease1.Fill_Detain_Info();

                fm.btnRelease.Enabled = false;
                fm.linkShowLicenseInfo.Enabled = true;

                return;

            }

            if (detain == null && isReleased == true)
            {
                MessageBox.Show(" MessageBox.Show(\"Selected License is Not Detained, Choose another one\", \"Not Allowed\", MessageBoxButtons.OK);");
                frmRelease_Detained_License fm = Application.OpenForms.OfType<frmRelease_Detained_License>().FirstOrDefault();
                fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                fm.cntrDetainInfo_For_frmRelease1.Fill_Detain_Info();

                fm.btnRelease.Enabled = false;
                fm.linkShowLicenseInfo.Enabled = true;

                return;

            }




            if (license.IsActive == true && isReplacementDamage == true)
            {
                frmRemplacementForDamageLicense fm = Application.OpenForms.OfType<frmRemplacementForDamageLicense>().FirstOrDefault();
                fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                fm.cntrApp_Info_For_Replacement_License1.Fill_Data();

                return;

            }
            if (license.IsActive == true && isDetainLisence == true)
            {
                frm_Detain_License frm = Application.OpenForms.OfType<frm_Detain_License>().FirstOrDefault();
                cntr_Detain_License cntr1 = new cntr_Detain_License();
                frm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                frm.cntr_Detain_License1.Fill_Detain_Info();
                frm.Show();

                return;


            }

            if ((license != null && license.ExpirationDate> DateTime.Now )&& isRenewActive ==true && license.IsActive==true )
            {
                
                    MessageBox.Show("Selected License Is not yet Expired; It will expired On" +   license.ExpirationDate, "Not Allowed", MessageBoxButtons.OK);
                    frm_Renew_License_Application fm = Application.OpenForms.OfType<frm_Renew_License_Application>().FirstOrDefault();
                    fm.btnRenew.Enabled = false;
                    fm.linkShowLicenseInfo.Enabled = true;
                    fm.linkLicenseHistory.Enabled = true;


                fm.cntrRenewLicenseApplication1.Fill_Renew_License_Application(license.LicenseID);
                fm.Show();
                return;
            }
            if ((license != null && license.ExpirationDate < DateTime.Now) && isRenewActive==true && license.IsActive==true)
            {

                frm_Renew_License_Application fm = Application.OpenForms.OfType<frm_Renew_License_Application>().FirstOrDefault();
                fm.btnRenew.Enabled = true;
                fm.linkShowLicenseInfo.Enabled = true;


                fm.cntrRenewLicenseApplication1.Fill_Renew_License_Application(license.LicenseID);
                fm.Show();
                return;
            }

            else if(international!= null  && isInternationalActive == true )
            {

                frmInternationalLicenseApplication fm = Application.OpenForms.OfType<frmInternationalLicenseApplication>().FirstOrDefault();
               
                    //fm.btnRenew.Enabled = true;
                    MessageBox.Show("Person already has an International active License with ID= " +  international.InternationalLicenseID, "Not Allowed", MessageBoxButtons.OK);
                   
                    
                   fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                   fm.cntr_InternationalLicenseApplication1.lblApplicationID.Text = international.ApplicationID.ToString();
                   fm.cntr_InternationalLicenseApplication1.lblApplicationDate.Text = international.IssueDate.ToString();
                   fm.cntr_InternationalLicenseApplication1.lblIssueDate.Text = international.IssueDate.ToString();
                   fm.cntr_InternationalLicenseApplication1.lblLocalLicenseID.Text = international.IssuedUsingLocalLicenseID.ToString();
                   fm.cntr_InternationalLicenseApplication1.lblExpirationDate.Text = international.ExpirationDate.ToString();
                   fm.cntr_InternationalLicenseApplication1.lblCreatedBy.Text = Users.Find(international.CreatedByUserID).UserName;
                  fm.cntr_InternationalLicenseApplication1.lblFees2.Text = AppType.FindApplicationTypesByID(6).ApplicationFees.ToString();







                   fm.btnIssue.Enabled = false;
                   
                   fm.linkShowLicenseInfo.Enabled = true;
                   fm.linkShowLicenseInfo.Enabled = true;

                fm.Show();
                    return;
                    
                
            }
            else if(international == null && isInternationalActive == true )
            {

                frmInternationalLicenseApplication fm = Application.OpenForms.OfType<frmInternationalLicenseApplication>().FirstOrDefault();
                
                   fm.cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(license.LicenseID);
                   //fm.cntr_InternationalLicenseApplication1.lblApplicationID.Text = international.ApplicationID.ToString();
                   fm.cntr_InternationalLicenseApplication1.lblApplicationDate.Text = DateTime.Now.ToString();
                   fm.cntr_InternationalLicenseApplication1.lblIssueDate.Text = DateTime.Now.ToString();
                   fm.cntr_InternationalLicenseApplication1.lblLocalLicenseID.Text = license.LicenseID.ToString();
                   fm.cntr_InternationalLicenseApplication1.lblExpirationDate.Text = license.ExpirationDate.ToString();
                   fm.cntr_InternationalLicenseApplication1.lblCreatedBy.Text = clsGlobal.name;
                   fm.cntr_InternationalLicenseApplication1.lblFees2.Text = AppType.FindApplicationTypesByID(6).ApplicationFees.ToString();


                fm.btnIssue.Enabled = true;
                fm.linkShowLicenseInfo.Enabled = false;
                fm.linkShowLicenseInfo.Enabled = true;

                fm.Show();
                return;
            }

            
                return;
        }

     

      
    }
}
