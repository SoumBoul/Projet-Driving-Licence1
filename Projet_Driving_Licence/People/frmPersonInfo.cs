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
using System.Xml.Linq;

namespace Projet_Driving_Licence
{
    public partial class frmPersonInfo : Form
    {
        int personID;
        Person person;
        public frmPersonInfo(int ID)
        {
            InitializeComponent();
            personID = ID;
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            person = Person.FindPersonWithID(personID);
            if (person == null)
            {
                Console.WriteLine("The Person Is Not Exist");
            }
            else
            {

                contrPersonInfo1.txtPersonID.Text = person.PersonID.ToString();
                contrPersonInfo1.txtNationalNo.Text = person.NationalNo;
                contrPersonInfo1.txtName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                contrPersonInfo1.txtDateOfBirth.Text = person.DateOfBirth.ToString();
                contrPersonInfo1.txtAddress.Text = person.Address;
                contrPersonInfo1.txtPhone.Text = person.Phone;
                contrPersonInfo1.txtEmail.Text = person.Email;
                if (person.Gendor == false)
                {
                    contrPersonInfo1.txtGendor.Text = "Male";
                }
                else

                {
                    contrPersonInfo1.txtGendor.Text = "Female";
                }
                if (person.ImagePath == null)
                {
                    contrPersonInfo1.MypbImage.ImageLocation = null;
                }
                else

                {
                    contrPersonInfo1.MypbImage.ImageLocation = person.ImagePath;
                }


                contrPersonInfo1.cbCountries.Text = Country.FindCountryByID(person.NationalityCountryID).CountryName;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
