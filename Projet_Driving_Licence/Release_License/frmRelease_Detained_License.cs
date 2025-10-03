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
    public partial class frmRelease_Detained_License : Form
    {
        public frmRelease_Detained_License()
        {
            InitializeComponent();
        }

       
        private void cntr_InternationalLicenseApplication1_Load(object sender, EventArgs e)
        {

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
           

            MyLicense license = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));

            DetainLicense detain = DetainLicense.FindDetain_License(license.LicenseID);
            App app = new App();
            MyLicense OldLicense = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));

            //app.ApplicationID = Convert.ToInt32(cntr_InternationalLicenseApplication1.lblApplicationID.Text);
            Person person = Person.FindPersonWithNationalNo(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblNationalNo.Text);
            app.ApplicationPersonID = person.PersonID;
            app.ApplicationDate = DateTime.Now;
            app.ApplicationTypeID = 5;
            app.ApplicationStatus = Convert.ToByte(LicenseClasses.FindLicenseClassWithName(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblClass.Text).LicenseClass);
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = Convert.ToDecimal(cntrDetainInfo_For_frmRelease1.lblApplicationFees.Text);
            app.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;

            if (app.Save())
            {
                detain.DetainID = Convert.ToInt32(cntrDetainInfo_For_frmRelease1.lblDetainID.Text);
                detain.LicenseID = Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text);
                detain.DetainDate = DateTime.Now;
                detain.FineFees = Convert.ToDecimal(cntrDetainInfo_For_frmRelease1.lblFineFees.Text);
                detain.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;
                detain.IsReleased = 1;
                detain.ReleaseDate = DateTime.Now;


                detain.ReleasedByUserID = Users.FindUserByName(clsGlobal.name).UserID;
                detain.ReleasedApplicationID = app.ApplicationID;

                if(detain.Save())
                {
                MessageBox.Show("License Released successffully whth ID= " + app.ApplicationID);
                cntrDetainInfo_For_frmRelease1.lblReleasedID.Text = detain.DetainID.ToString();
                btnRelease.Enabled = false;
                    linkShowLicenseInfo.Enabled = true;
                }

            }
               
         

        }

        private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));
            frm.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_Info(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));
            frm.Show();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
