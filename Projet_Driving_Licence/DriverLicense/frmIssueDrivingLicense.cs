using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using ClassBusinesLayerDrivingLicense;

namespace Projet_Driving_Licence
{
    public partial class frmIssueDrivingLicense : Form
    {
        int DrivingID;
        string nationalno = "";
        clsGlobal global = new clsGlobal();
        public frmIssueDrivingLicense(int ID)
        {
            InitializeComponent();

            DrivingID = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            frm_Local_Driving_License_App fm = Application.OpenForms.OfType<frm_Local_Driving_License_App>().FirstOrDefault();
           
            Driver driver = new Driver();
            MyLicense license = new MyLicense();
            
            if(fm.dgLocalDriving.CurrentCell!=null && fm.dgLocalDriving.CurrentRow.Cells[2].Value !=  null)
            {
                  nationalno = fm.dgLocalDriving.CurrentRow.Cells[2].Value.ToString();
            }

            Person person = Person.FindPersonWithNationalNo(nationalno);

            driver.PersonID = Convert.ToInt32(person.PersonID);
            driver.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;
            driver.CreatedDate = Convert.ToDateTime(cntrDrvingLicenseInformation1.lblDate.Text);

            Driver driver1 = Driver.FindDriver(nationalno);

            if (driver1!=null)
            {
                App app = App.FindApplicationWithID(Convert.ToInt32(cntrDrvingLicenseInformation1.lblID.Text));

                license.ApplicationID = Convert.ToInt32(cntrDrvingLicenseInformation1.lblID.Text);
                license.DriverID = driver1.DriverID;
                license.LicenseClass = LicenseClasses.FindLicenseClassWithName(cntrDrvingLicenseInformation1.lblClassName.Text).LicenseClass;
                LicenseClasses Lenght = LicenseClasses.FindApplicationClassWithID_Validity_Length(license.LicenseClass);
                license.IssueDate = Convert.ToDateTime(cntrDrvingLicenseInformation1.lblStatusDate.Text);
                license.ExpirationDate = Convert.ToDateTime(license.IssueDate.AddYears(Lenght.DefaultValidityLength).ToString("yyyy/MM/dd"));
                license.Notes = txtNotes.Text;
                license.PaidFees = Convert.ToDecimal(cntrDrvingLicenseInformation1.lblFees.Text);
                license.IsActive = true;
                license.IssueReason = app.ApplicationTypeID;
                license.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;

                if (license.Save() )

                {
                    MessageBox.Show("License Saved Successffully");
                    


                }
                else
                {
                    MessageBox.Show("License NOT Saved ");
                }
                return;

            }

            else

            {
                if (driver.Save())
                {

                    App app = App.FindApplicationWithID(Convert.ToInt32(cntrDrvingLicenseInformation1.lblID.Text));

                    license.ApplicationID = Convert.ToInt32(cntrDrvingLicenseInformation1.lblDrivingLicenseID.Text);
                    license.DriverID = driver.DriverID;
                    license.LicenseClass = LicenseClasses.FindLicenseClassWithName(cntrDrvingLicenseInformation1.lblClassName.Text).LicenseClass;
                    LicenseClasses Lenght = LicenseClasses.FindApplicationClassWithID_Validity_Length(license.LicenseClass);
                    license.IssueDate = Convert.ToDateTime(cntrDrvingLicenseInformation1.lblStatusDate.Text);
                    license.ExpirationDate = Convert.ToDateTime(license.IssueDate.AddYears(Lenght.DefaultValidityLength).ToString("yyyy/MM/dd"));
                    license.Notes = txtNotes.Text;
                    license.PaidFees = Convert.ToDecimal(cntrDrvingLicenseInformation1.lblFees.Text);
                    license.IsActive = true;
                    license.IssueReason = app.ApplicationTypeID;
                    license.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;

                    if (license.Save())
                    {
                        MessageBox.Show("License Saved Successffully");


                    }
                    else
                    {
                        MessageBox.Show("License NOT Saved ");
                    }


                }

                else
                {
                    MessageBox.Show("License NOT Saved ");
                }

            }

        }
    }
}
