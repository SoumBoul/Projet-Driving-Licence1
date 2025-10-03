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
    public partial class contrPersonInfo : UserControl
    {
        Person _person;

        public int ID { get; set; }
        public string Name  {get;set;}

        public contrPersonInfo()
        {
            InitializeComponent();
        }

       
         public   void   LoadMy_data(string nationalNo)
        {

            Name = nationalNo;



            if (Name == null)
            {
                return;
            }

          
            _person = Person.FindPersonWithNationalNo(Name);
            if(_person==null)
            {
                MessageBox.Show("The Person Is Not Exist");
                return;
            }

            txtPersonID.Text = _person.PersonID.ToString();
            txtNationalNo.Text = _person.NationalNo;
            txtName.Text = _person.FirstName +" " + _person.SecondName +" "+ _person.ThirdName+" " + _person.LastName;

            txtDateOfBirth.Text = _person.DateOfBirth.ToString();
            txtAddress.Text = _person.Address;
            txtPhone.Text = _person.Phone;
            txtEmail.Text = _person.Email;
            txtGendor.Text = Convert.ToBoolean(_person.Gendor).ToString();
            cbCountries.Text = Country.FindCountryByID(_person.NationalityCountryID).CountryName;

            if (_person.ImagePath == "")
            {
                MypbImage.ImageLocation = "";
            }
            else

            {
                MypbImage.ImageLocation = _person.ImagePath;
            }

          



        }

        private void contrPersonInfo_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
