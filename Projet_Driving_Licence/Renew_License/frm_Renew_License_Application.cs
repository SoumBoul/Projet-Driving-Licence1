using ClassBusinesLayerDrivingLicense;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Driving_Licence
{
    public partial class frm_Renew_License_Application : Form
    {
        public frm_Renew_License_Application()
        {
            InitializeComponent();
        }

        private void frm_Renew_License_Application_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            App app = new App();
            MyLicense OldLicense = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));

            app.ApplicationID = Convert.ToInt32(cntr_InternationalLicenseApplication1.lblApplicationID.Text);
            Person person = Person.FindPersonWithNationalNo(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblNationalNo.Text);
            app.ApplicationPersonID = person.PersonID;
            app.ApplicationDate = DateTime.Now;
            app.ApplicationTypeID = 2;
            app.ApplicationStatus = Convert.ToByte(LicenseClasses.FindLicenseClassWithName(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblClass.Text).LicenseClass);
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = Convert.ToDecimal(cntr_InternationalLicenseApplication1.lblFees2.Text);
            app.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;

            if (app.Save())
            {
                MyLicense license = new MyLicense();
                


                license.ApplicationID = app.ApplicationID;
                license.DriverID = Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblDriverID.Text);
                license.LicenseClass = LicenseClasses.FindLicenseClassWithName(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblClass.Text).LicenseClass;
                int year = Convert.ToInt32(LicenseClasses.FindApplicationClassWithID_Validity_Length(license.LicenseClass).DefaultValidityLength);
                license.IssueDate = DateTime.Now;
                license.ExpirationDate = Convert.ToDateTime(("0") + (license.ExpirationDate.Day) + "/" + "0" + (license.ExpirationDate.Month) + "/" + (license.ExpirationDate.Year + year));
                license.IsActive = true;
                license.IssueReason = AppType.FindApplicationTypeByName(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblIssueReason.Text).ApplicationTypeID;
                license.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;

                if (license.Save())
                {

                    OldLicense.LicenseID = Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text);
                    OldLicense.IsActive = false;
                    if (OldLicense.Save())
                    {
                        MessageBox.Show("License Renewed Successffully with ID= " + license.LicenseID);

                    }

                }


                cntrRenewLicenseApplication1.lblR_L_ApplicationID.Text = app.ApplicationID.ToString();
                cntrRenewLicenseApplication1.lblRenewedLicenseID.Text = license.LicenseID.ToString();

                linkShowLicenseInfo.Enabled = true;
            }





        }

        private void cntr_InternationalLicenseApplication1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            
            cntrDriverLiceseInfo1 cntr = new cntrDriverLiceseInfo1();
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));
            frm.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));
            frm.Show();


        }


    }
}
