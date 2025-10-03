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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Projet_Driving_Licence
{
    public partial class frmChangePassWord : Form
    {
       
        private enum enMode { AddNew = 0, Update = 1 };
        enMode Mode;
        Person _person;
        Users user;
        int userID;
        public frmChangePassWord(int ID)
        {
            InitializeComponent();
            userID = ID;
        }
        private void LoadData()
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

            if (_person.ImagePath == null)
            {
                contrPersonInfo1.MypbImage.ImageLocation = null;
            }
            else

            {
                contrPersonInfo1.MypbImage.ImageLocation = _person.ImagePath;
            }

            user = Users.FindWithPersonID(userID);

            if (user == null)
            {
                return;
            }

            lblUserID.Text = user.UserID.ToString();
            lblUserName.Text = user.UserName;
            lblIsActive.Text = user.IsActive.ToString();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPersons(object sender, int personID, string nationalNo, string firstName, string secondname, string thirdname,
            string lastname, string dateofbirth, bool gendor, string address, string phone, string email, int nationalitycountryID, string imagepath)
        {
            contrPersonInfo1.txtPersonID.Text = personID.ToString();
            contrPersonInfo1.txtNationalNo.Text = nationalNo;
            contrPersonInfo1.txtName.Text = firstName + " " + secondname + " " + thirdname + " " + lastname;
            contrPersonInfo1.txtDateOfBirth.Text = dateofbirth.ToString();
            contrPersonInfo1.txtGendor.Text = gendor.ToString();
            contrPersonInfo1.txtAddress.Text = address;
            contrPersonInfo1.txtPhone.Text = phone;
            contrPersonInfo1.txtEmail.Text = email;
            contrPersonInfo1.cbCountries.Text = nationalitycountryID.ToString();


        }

        private void frmChangePassWord_Load(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(-1);
            LoadData();
            frm.Load_PersonData += LoadPersons;
        }

        private void txtCurrentPassword_Validating_1(object sender, CancelEventArgs e)
        {
            int personid = Convert.ToInt32(contrPersonInfo1.txtPersonID.Text);
            Users user = Users.FindWithPersonID(personid);
            if (user.PassWord != txtCurrentPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "the current password is Not Exact");
                txtCurrentPassword.Focus();
            }

            else
            {
                errorProvider1.SetError(txtCurrentPassword, "");
            }
        }

     

        private void txtConfirmPassWord_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassWord.Text != txtNewPassWord.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassWord, "Confirm Password is Not exact ");
                txtConfirmPassWord.Focus();
            }

            else
            {
                errorProvider1.SetError(txtConfirmPassWord, "");
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int personid = Convert.ToInt32(contrPersonInfo1.txtPersonID.Text);


            Users user = Users.FindWithPersonID(personid);
            user.PassWord = txtNewPassWord.Text;




            if (user.Save())
            {
                MessageBox.Show("The PassWord Saved Succussffully");

            }

            else
                MessageBox.Show("The PassWord is Not saved");


        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
