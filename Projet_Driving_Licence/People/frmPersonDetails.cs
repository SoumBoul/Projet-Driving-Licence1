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
    public partial class frmPersonDetails : Form
    {

        private enum enMode { AddNew = 0, Update = 1 };
        enMode Mode;
        Person _person;
       
        int userID;
        public frmPersonDetails(int ID)
        {
            InitializeComponent();
            userID = ID;
        }
        public void LoadData()
        {



            _person = Person.FindPersonWithID(userID);
            if (_person == null)
            {
                return;
            }

            contrPersonInfo1.txtPersonID.Text = _person.PersonID.ToString();
            contrPersonInfo1.txtNationalNo.Text = _person.NationalNo;
            contrPersonInfo1.txtName.Text = _person.FirstName;

            contrPersonInfo1.txtDateOfBirth.Text = _person.DateOfBirth.ToString();
            contrPersonInfo1.txtAddress.Text = _person.Address;
            contrPersonInfo1.txtPhone.Text = _person.Phone;
            contrPersonInfo1.txtEmail.Text = _person.Email;
            contrPersonInfo1.txtGendor.Text = Convert.ToBoolean(_person.Gendor).ToString();
            contrPersonInfo1.cbCountries.Text = Country.FindCountryByID(_person.NationalityCountryID).CountryName;

            if (_person.ImagePath == "")
            {
                contrPersonInfo1.MypbImage.ImageLocation = "";
            }
            else

            {
                contrPersonInfo1.MypbImage.ImageLocation = _person.ImagePath;
            }

            Users user = new Users();
            user = Users.FindWithPersonID(userID);

            if (user == null)
            {
                return;
            }

            lblUserID.Text = user.UserID.ToString();
            lblUserName.Text = user.UserName;
            lblIsActive.Text = user.IsActive.ToString();







        }



        private void frmPersonDetails_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
