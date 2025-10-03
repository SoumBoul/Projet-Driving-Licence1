using ClassBusinesLayerDrivingLicense;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet_Driving_Licence
{
    public partial class frmInternationalLicenseApplication : Form
    {
        public frmInternationalLicenseApplication()
        {
            InitializeComponent();
        }
        private void cntr_InternationalLicenseApplication1_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            MyLicense license = MyLicense.FindLicenseWith_LicenseID(Convert.ToInt32(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblLicenseID.Text));

            frmLicenseHistory frm = new frmLicenseHistory(license.ApplicationID);
            frm.contrPersonInfo1.LoadMy_data(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblNationalNo.Text);

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadData();
        }

        private void frmInternationalLicenseApplication_Load(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            App app = new App();

         
            Person person = Person.FindPersonWithNationalNo(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblNationalNo.Text);
            app.ApplicationPersonID = person.PersonID;
            app.ApplicationDate = Convert.ToDateTime(cntr_InternationalLicenseApplication1.lblApplicationDate.Text);
            app.ApplicationTypeID = 6;
            app.ApplicationStatus = Convert.ToByte(LicenseClasses.FindLicenseClassWithName(cntr_InternationalLicenseApplication1.cntrDriverLiceseInfo11.lblClass.Text).LicenseClass);
            app.LastStatusDate = Convert.ToDateTime(cntr_InternationalLicenseApplication1.lblExpirationDate.Text);
            app.PaidFees = Convert.ToDecimal(cntr_InternationalLicenseApplication1.lblFees2.Text);
            app.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;

            if (app.Save())
            {

                cntr_InternationalLicenseApplication1.lblApplicationID.Text = (Convert.ToInt32(app.ApplicationID).ToString());
                InternationalLicense internationalLicense = new InternationalLicense();
                Driver driver = Driver.FindDriver(person.NationalNo);

               
                internationalLicense.ApplicationID = app.ApplicationID;
                internationalLicense.DriverID = driver.DriverID;
                internationalLicense.IssuedUsingLocalLicenseID = Convert.ToInt32(cntr_InternationalLicenseApplication1.txtLicenseID.Text);
                internationalLicense.IssueDate = app.ApplicationDate;
                MyLicense license = MyLicense.FindLicenseWith_LicenseID(internationalLicense.IssuedUsingLocalLicenseID);

                internationalLicense.ExpirationDate = app.LastStatusDate;
                if(license.IsActive== true)
                {
                    internationalLicense.IsActive = true;
                }
                else
                {
                    internationalLicense.IsActive = false;
                    MessageBox.Show("This License is NOT Active");
                    return;
                }
                internationalLicense.CreatedByUserID = app.CreatedByUserID;

                if (internationalLicense.Save())
                {
                    MessageBox.Show("Data Saved Successfully");

                    cntr_InternationalLicenseApplication1.lblLicenseID.Text = internationalLicense.InternationalLicenseID.ToString();
                    cntr_InternationalLicenseApplication1.lblApplicationID.Text = internationalLicense.ApplicationID.ToString();
                    linkShowLicenseInfo.Enabled = true;
                    linkShowLicenseInfo.Enabled = true;
                    btnIssue.Enabled = false;

                }

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cntrDriverLiceseInfo1 cntr = new cntrDriverLiceseInfo1();
            frmInternationalLicenseApplication fm = Application.OpenForms.OfType<frmInternationalLicenseApplication>().FirstOrDefault();
            frm_Driver_International_LicenseInfo frm = new frm_Driver_International_LicenseInfo(Convert.ToInt32(fm.cntr_InternationalLicenseApplication1.txtLicenseID.Text));
            
            
            frm.Show();


        }

       
    }
}

