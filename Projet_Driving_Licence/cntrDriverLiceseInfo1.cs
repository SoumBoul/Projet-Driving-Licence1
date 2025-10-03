using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClassBusinesLayerDrivingLicense;

namespace Projet_Driving_Licence
{
    
    public partial class cntrDriverLiceseInfo1 : UserControl
    {
       
         public cntrDriverLiceseInfo1()
        {
            InitializeComponent();
        }


        public void Load_DrivingLicense_With_LicenseID_Info(int LicenseID)
        {
            MyLicense license = MyLicense.FindLicenseWith_LicenseID(LicenseID);

            if(license== null)
            {
                MessageBox.Show("This License Is Not Exist");
                return;
            }
            Driver driver = Driver.FindDriver_WithDriverID(license.DriverID);
            Person person = Person.FindPersonWithID(driver.PersonID);
            App app = App.FindApplicationWithNationalNo(person.NationalNo);
            App app1 = App.FindApplicationWithID(license.ApplicationID);

            DetainLicense detain = DetainLicense.FindDetain_License(LicenseID);

            lblClass.Text = LicenseClasses.FindApplicationClassWithID(license.LicenseClass).LicenseClassName;
            lblName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            lblLicenseID.Text = license.LicenseID.ToString();
            lblNationalNo.Text = person.NationalNo.ToString();
            if(person.Gendor==false)
            { lblGendor.Text = "Male"; }
            else { lblGendor.Text = "Female"; }
            lblIssueDate.Text = app.AppDate.ToString();
            lblIssueReason.Text = AppTypes.FindApplicationTypes(app1.ApplicationTypeID).Title;
            lblNotes.Text = license.Notes;
            lblIsActive.Text = license.IsActive.ToString();
            lblDateOfBirth.Text = person.DateOfBirth.ToString();
            lblDriverID.Text = license.DriverID.ToString();
            
           
            lblExpirationDate.Text = license.ExpirationDate.ToString() ;

            
            if(detain == null ||  detain.IsReleased== 1)
            {
                lblIsDetained.Text = "NO";
            }
            else
            { 
                lblIsDetained.Text = "yes";
            }

            if (person.ImagePath != "")
            {
                MyPicture1.ImageLocation = person.ImagePath;
            }
            else
                MyPicture1.ImageLocation = DBNull.Value.ToString();



        }

        public void Load_DrivingLicense_With_LicenseID_InfoWith_LoD_L(int Lo_D_L)
        {
            DataTable local = Local_Driving_License_App.GetAllDrivingLicenseApplications(Lo_D_L);
            MyLicense license;
            object num=-1;
            foreach (DataRow row in local.Rows)
            {
               num= row["ApplicationID"];
            }
            license = MyLicense.FindLicenseWith_ApplicationID(Convert.ToInt32(num));

            if (license == null)
            {
                MessageBox.Show("This License Is Not Exist");
                return;
            }
            Driver driver = Driver.FindDriver_WithDriverID(license.DriverID);
            Person person = Person.FindPersonWithID(driver.PersonID);
            App app = App.FindApplicationWithNationalNo(person.NationalNo);
            App app1 = App.FindApplicationWithID(license.ApplicationID);


            DetainLicense detain = DetainLicense.FindDetain_License(license.LicenseID);

            lblClass.Text = LicenseClasses.FindApplicationClassWithID(license.LicenseClass).LicenseClassName;
            lblName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            lblLicenseID.Text = license.LicenseID.ToString();
            lblNationalNo.Text = person.NationalNo.ToString();
            if (person.Gendor == false)
            { lblGendor.Text = "Male"; }
            else { lblGendor.Text = "Female"; }
            lblIssueDate.Text = app.AppDate.ToString();
            lblIssueReason.Text = AppTypes.FindApplicationTypes(app1.ApplicationTypeID).Title;
            lblNotes.Text = license.Notes;
            lblIsActive.Text = license.IsActive.ToString();
            lblDateOfBirth.Text = person.DateOfBirth.ToString();
            lblDriverID.Text = license.DriverID.ToString();


            lblExpirationDate.Text = license.ExpirationDate.ToString();
            if (detain == null || detain.IsReleased == 1)
            {
                lblIsDetained.Text = "NO";
            }
            else
            {
                lblIsDetained.Text = "yes";
            }



            if (person.ImagePath != "")
            {
                MyPicture1.ImageLocation = person.ImagePath;
            }
            else
                MyPicture1.ImageLocation = DBNull.Value.ToString();



        }

        private void cntrDriverLiceseInfo1_Load(object sender, EventArgs e)
        {
            




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
