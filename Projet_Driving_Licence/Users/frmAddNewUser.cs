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
using static Projet_Driving_Licence.frmAddNewPerson;
using System.Windows.Controls;
using Projet_Driving_Licence;

namespace Projet_Driving_Licence
{
    public partial class frmAddNewUser : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;
        Users user;
        Person _person;
        int userID;

        public frmAddNewUser(int ID)
        {
            InitializeComponent();
            userID = ID;
            if (userID == -1)
            {
                Users user = new Users();
                Mode = enMode.AddNew;
            }

            else
                Mode = enMode.Update;
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

            user = Users.FindWithPersonID(_person.PersonID);

            if (user == null)
            {
                return;
            }
            lblUserID.Text = user.UserID.ToString();
            txtUserName.Text = user.UserName;
            txtPassWord.Text = user.PassWord;
            if (user.IsActive)
            {
                cbIsActive.Checked = true;
            }

            else
            { cbIsActive.Checked = false; }
            txtConfirmPassWord.Text = user.PassWord;


        }


        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();
            LoadData();
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            Person person = Person.FindPersonWithNationalNo(txtFilterBy.Text);

            if (person != null)
            {

                contrPersonInfo1.txtPersonID.Text = person.PersonID.ToString();
                contrPersonInfo1.txtNationalNo.Text = person.NationalNo;
                contrPersonInfo1.txtName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                if (person.Gendor == false)
                {
                    contrPersonInfo1.txtGendor.Text = "Female";

                }
                else
                    contrPersonInfo1.txtGendor.Text = "Male";
                contrPersonInfo1.txtAddress.Text = person.Address;
                contrPersonInfo1.txtEmail.Text = person.Email;
                contrPersonInfo1.txtPhone.Text = person.Phone;
                contrPersonInfo1.txtDateOfBirth.Text = person.DateOfBirth.ToString();
                contrPersonInfo1.MypbImage.ImageLocation = person.ImagePath;

                contrPersonInfo1.cbCountries.Text = Country.FindCountryByID(person.NationalityCountryID).CountryName;



            }
            else
                MessageBox.Show("The Person Is NOT Exist");
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = true;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Person _person = new Person();
            lblTitre.Text = "Update Person ";
            _person.NationalNo = contrPersonInfo1.txtNationalNo.Text;
            _person.FirstName = contrPersonInfo1.txtName.Text;
            _person.DateOfBirth = Convert.ToDateTime(contrPersonInfo1.txtDateOfBirth.Text);
            if (contrPersonInfo1.txtGendor.Text == "female")
            { _person.Gendor = true; }
            else
            { _person.Gendor = false; }
            _person.Address = contrPersonInfo1.txtAddress.Text;
            _person.Phone = contrPersonInfo1.txtPhone.Text;
            _person.Email = contrPersonInfo1.txtEmail.Text;

            _person.NationalityCountryID = Country.FindCountryByName(contrPersonInfo1.cbCountries.Text).CountryID;


            if (_person.ImagePath == null)
            {
                _person.ImagePath = DBNull.Value.ToString();
            }
            else

            {
                _person.ImagePath = contrPersonInfo1.MypbImage.ImageLocation;
            }



            Mode = enMode.Update;

            if (_person.Save())
            {
                MessageBox.Show("The Person Saved Susccussuffully");


            }

            else
            {
                Console.WriteLine("Yhe Person  NOT Saved ");
            }

            Users user = new Users();

            //user = Users.FindUserByName(txtUserName.Text);
            user.UserName = txtUserName.Text;
            user.PersonID = Convert.ToInt32(contrPersonInfo1.txtPersonID.Text);
            user.PassWord = txtPassWord.Text;
            user.IsActive = cbIsActive.Checked;


            if (user.Save())
            {
                MessageBox.Show("The User Saved Succussffully");

            }

            else
            { MessageBox.Show("The User is Not saved"); }

            int UsersID = Convert.ToInt32(contrPersonInfo1.txtPersonID.Text);

            user = Users.FindWithPersonID(UsersID);

            lblUserID.Text = user.UserID.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int userNum = Convert.ToInt32(contrPersonInfo1.txtPersonID.Text);
            Users user = Users.FindWithPersonID(userNum);
            if (user != null)
            {
                MessageBox.Show("Selected Person already has a user , choose another one", "Select another person", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else

                tabControl1.SelectedTab = LoginInfo;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(-1);

            frm.Load_PersonData += Load_Persons;
            frm.Show();
        }

        private void Load_Persons(object sender, int personID, string nationalNo, string firstName, string secondname, string thirdname,
              string lastname, string dateofbirth, bool gendor, string address, string phone, string email, int nationalitycountryID, string imagepath)
        {

            _person = Person.FindPersonWithNationalNo(nationalNo);
            contrPersonInfo1.txtPersonID.Text = _person.PersonID.ToString();
            contrPersonInfo1.txtNationalNo.Text = nationalNo;
            contrPersonInfo1.txtName.Text = firstName + " " + secondname + " " + thirdname + " " + lastname;
            contrPersonInfo1.txtDateOfBirth.Text = dateofbirth;
            contrPersonInfo1.txtGendor.Text = gendor.ToString();
            contrPersonInfo1.txtAddress.Text = address;
            contrPersonInfo1.txtPhone.Text = phone;
            contrPersonInfo1.txtEmail.Text = email;
            contrPersonInfo1.cbCountries.Text = Country.FindCountryByID(nationalitycountryID).CountryName;
            contrPersonInfo1.MypbImage.ImageLocation = imagepath;


        }
        private void frmAddNewUser_Load_1(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(userID);
            LoadData();
            frm.Load_PersonData += Load_Persons;
            frm.Show();
        }

        private void txtUserName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "you have to enter UserName");
                txtUserName.Focus();
            }
            else
            {

                errorProvider1.SetError(txtUserName, "");

            }
        }

        private void txtPassWord_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassWord.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassWord, "PassWord cannot be blank");
                txtUserName.Focus();
            }
            else
            {

                errorProvider1.SetError(txtPassWord, "");

            }
        }

        private void txtConfirmPassWord_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassWord.Text) || txtPassWord.Text != txtConfirmPassWord.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassWord, "Confirm Password does not match Password");
                txtUserName.Focus();
            }
            else
            {

                errorProvider1.SetError(txtConfirmPassWord, "");

            }
        }

      
        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
       
    }
}
}
    

    
