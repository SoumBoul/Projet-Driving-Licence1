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
    public partial class frmRemplacementForDamageLicense : Form
    {
        public frmRemplacementForDamageLicense()
        {
            InitializeComponent();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            App app = new App();

            MyLicense license = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));
            app.ApplicationID = (license.ApplicationID);

            Person person = Person.FindPersonWithNationalNo(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblNationalNo.Text);
            app.ApplicationPersonID = person.PersonID;
            app.ApplicationDate = DateTime.Now;
            if(RBDamage.Checked)
            {
                app.ApplicationTypeID = 4;
            }
            else if(RBLost.Checked)
            {
                app.ApplicationTypeID = 3;
            }
            app.ApplicationStatus = Convert.ToByte(LicenseClasses.FindLicenseClassWithName(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblClass.Text).LicenseClass);
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = Convert.ToDecimal(cntrApp_Info_For_Replacement_License1.lblApplicationFees.Text);
            app.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;

            if (app.Save())
            {
                frmRemplacementForDamageLicense fm = Application.OpenForms.OfType<frmRemplacementForDamageLicense>().FirstOrDefault();
                 license = new MyLicense();
                MyLicense OldLicense = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));


                license.ApplicationID = app.ApplicationID;
                license.DriverID = Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblDriverID.Text);
                license.LicenseClass = LicenseClasses.FindLicenseClassWithName(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblClass.Text).LicenseClass;
                
                license.IssueDate = DateTime.Now;
                license.ExpirationDate = OldLicense.ExpirationDate;
                license.IsActive = true;
                license.IssueReason = AppType.FindApplicationTypeByName(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblIssueReason.Text).ApplicationTypeID;
                license.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;

                if (license.Save())
                {

                    cntrApp_Info_For_Replacement_License1.lbl_L_R_ApplicationID.Text = app.ApplicationID.ToString();
                    cntrApp_Info_For_Replacement_License1.lblRenewedLicenseID.Text = license.LicenseID.ToString();

                    linkShowLicenseInfo.Enabled = true;

                    license = MyLicense.FindLicenseWith_LicenseID(OldLicense.LicenseID);
                    OldLicense.IsActive = false;

                    if (OldLicense.Save())
                    {

                    }
                    MessageBox.Show("License Replaced Successffully with ID= " + license.LicenseID);
                    fm.linkShowLicenseInfo.Enabled = true;
                  

                }


               
            }


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
    }
}
