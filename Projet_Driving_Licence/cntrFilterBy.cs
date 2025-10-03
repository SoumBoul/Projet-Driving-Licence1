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
    public partial class cntrFilterBy : UserControl
    {
        public cntrFilterBy()
        {
            InitializeComponent();
        }

        private void txtFilterBy_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            contrPersonInfo control = new contrPersonInfo();
            Person person = Person.FindPersonWithNationalNo(txtFilterBy.Text);

            if (person != null)
            {

                control.txtPersonID.Text = person.PersonID.ToString();
                control.txtNationalNo.Text = person.NationalNo;
                control.txtName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                if (person.Gendor == false)
                {
                    control.txtGendor.Text = "Female";

                }
                else
                    control.txtGendor.Text = "Male";
                control.txtAddress.Text = person.Address;
                control.txtEmail.Text = person.Email;
                control.txtPhone.Text = person.Phone;
                control.txtDateOfBirth.Text = person.DateOfBirth.ToString();
                control.MypbImage.ImageLocation = person.ImagePath;

                control.cbCountries.Text = Country.FindCountryByID(person.NationalityCountryID).CountryName;



            }
            else
                MessageBox.Show("The Person Is NOT Exist");

            //Users user = Users.FindWithPersonID(person.PersonID);
            //txtApplicationDate.Text = DateTime.Now.ToString();
            //txtApplicationFees.Text = "";
            //txtCreatedBY.Text = user.UserName;

        }

        

        
    }
}
