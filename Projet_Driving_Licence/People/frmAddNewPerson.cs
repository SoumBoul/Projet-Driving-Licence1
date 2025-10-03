using ClassBusinesLayerDrivingLicense;
using Projet_Driving_Licence.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;



namespace Projet_Driving_Licence

{
    public partial class frmAddNewPerson : Form
    {
        public delegate void LoadPersonsdata(object sender, int personID, string nationalNo, string firstName, string secondname, string thirdname,
           string lastname, string dateofbirth, bool gendor, string address, string phone, string email, int nationalitycountryID, string imagepath);

        public event LoadPersonsdata Load_PersonData;

        public enum EnMode { AddNew = 0, Update = 1 };
        EnMode Mode;

        int personID = 0;
        Person _person;
        Users user;
        
        public frmAddNewPerson(int ID)
        {
            InitializeComponent();

            personID = ID;
            if (personID == -1)
            {
                Mode = EnMode.AddNew;
            }

            else
            {
                Mode = EnMode.Update;
            }

        }

        public void GetPersonData()
        {

            int ID = Convert.ToInt32(lblPersonID.Text);
            if(ID ==-1)
            {

            }
            string nationalNo = txtNationalNo.Text;
            string firstName = txtFirstName.Text;
            string secondName = txtSecondName.Text;
            string thirdName = txtThirdName.Text;
            string lastName = txtLastName.Text;
            string dateOfBirth = dpDateOfBirth.Value.ToString();

            bool Gendor = rbMale.Checked;

            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            int nationalitycountryID = Country.FindCountryByName(cbCountries.Text).CountryID;
            string imagepath = pbImage.ImageLocation;

            if (Load_PersonData == null)
            {
                return;
            }
            Load_PersonData.Invoke(this, ID, nationalNo, firstName, secondName, thirdName, lastName, dateOfBirth,
                Gendor, address, phone, email, nationalitycountryID, imagepath);

        }

        private void RefreshDataGird()
        {
            Form2 frm = new Form2();
            frm.dgPeople.DataSource = Person.GetAllPeople();
            frm.Show();
        }
        private void RefreshCountriesData()
        {
            DataTable country = Country.GetAllCountries();
            foreach (DataRow row in country.Rows)
            {
                cbCountries.Items.Add(row["countryName"]);
            }
            cbCountries.SelectedIndex = 119;

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
           

        }
        private void FillForderWithImages()
        {

            string NewPath = "C:\\MyImages";

            if (!Directory.Exists(NewPath))
            {
                Directory.CreateDirectory(NewPath).ToString();
            }

            Guid gd = Guid.NewGuid();
            string fileName = Path.GetFileNameWithoutExtension(_person.ImagePath); // ImageName sans extension
            if (fileName == "")
            {
                return;
            }

            else
            {
                string fileExtension = Path.GetExtension(_person.ImagePath); // Extension du fichier

                string uniqueFileName = $"{fileName}{gd}{fileExtension}";
                

                // Construire le chemin de destination
                string destinationPath = Path.Combine(NewPath, uniqueFileName);
                if (_person.ImagePath == null)
                {
                    return;
                }


                File.Copy(_person.ImagePath, destinationPath);
            }

        }
        private void LoadData()
        {

            RefreshCountriesData();
            if (Mode == EnMode.AddNew)
            {

                _person = new Person();
                lblTitre.Text = "Add New Person";
                linkRemoveImage.Visible = false;
                return;

            }

            if (personID == -1)
            {
                Console.WriteLine("the person is not exist ");
                return;
            }

            user = Users.FindWithPersonID(Convert.ToInt32(personID));

            _person = Person.FindPersonWithID(personID);
            lblTitre.Text = "Update Person ";
            lblPersonID.Text = _person.PersonID.ToString();
            txtNationalNo.Text = _person.NationalNo;
            txtFirstName.Text = _person.FirstName;
            txtSecondName.Text = _person.SecondName;
            txtThirdName.Text = _person.ThirdName;
            txtLastName.Text = _person.LastName;
            dpDateOfBirth.Value = _person.DateOfBirth;
            txtAddress.Text = _person.Address;
            txtPhone.Text = _person.Phone;
            txtEmail.Text = _person.Email;

            cbCountries.Text = Country.FindCountryByID(_person.NationalityCountryID).CountryName;

            if (_person.ImagePath == null)
            {
                pbImage.ImageLocation = null;
            }
            else

            {
                pbImage.ImageLocation = _person.ImagePath;
            }
            linkRemoveImage.Visible = true;

            RefreshDataGird();


        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            _person.ImagePath = "";
            pbImage.ImageLocation = _person.ImagePath;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            //GetPersonData();
            

        }
        private void frmAddNewPerson_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
       private void linkSetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            of.ShowDialog();

            pbImage.ImageLocation = of.FileName;
        }

        private void txtNationalNo_Validating_1(object sender, CancelEventArgs e)
        {
            Person person = Person.FindPersonWithNationalNo(txtNationalNo.Text);
            if (person != null)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "sorry, this NationalNo is already Exist");
                txtNationalNo.Focus();
            }

            else
            {
                errorProvider1.SetError(txtNationalNo, "");
            }
        }

        private void txtEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "";
            }
            else if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".")))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "sorry, the format is Not Exact");
                txtNationalNo.Focus();
            }
            else
            {

                errorProvider1.SetError(txtNationalNo, "");

            }

        }

        private void txtAddress_Validating_1(object sender, CancelEventArgs e)
            {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "you have to fill this control");
                txtNationalNo.Focus();
            }
            else
            {

                errorProvider1.SetError(txtNationalNo, "");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            linkRemoveImage.Visible = true;
            lblTitre.Text = "Update Person ";
            _person.NationalNo = txtNationalNo.Text;
            _person.FirstName = txtFirstName.Text;
            _person.SecondName = txtSecondName.Text;
            _person.ThirdName = txtThirdName.Text;
            _person.LastName = txtLastName.Text;
            _person.DateOfBirth = dpDateOfBirth.Value;
            _person.Gendor = rbFemale.Checked ? true : rbMale.Checked ? false : false;

            _person.Address = txtAddress.Text;
            _person.Phone = txtPhone.Text;
            _person.Email = txtEmail.Text;
            _person.NationalityCountryID = cbCountries.SelectedIndex;
            if (_person.ImagePath == null)
            {
                _person.ImagePath = DBNull.Value.ToString();
            }
            else

            {
                _person.ImagePath = pbImage.ImageLocation;
            }

            FillForderWithImages();

            Mode = EnMode.Update;

            if (_person.Save())
            {
                MessageBox.Show("The Person Saved Successffully");


            }

            else
            {
                Console.WriteLine("Yhe Person  NOT Saved ");
            }
            lblPersonID.Text = _person.PersonID.ToString();
            

        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {

            GetPersonData();
            this.Close();
            
          

        }

        private void rbMale_CheckedChanged_2(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                pbImage.Image = Resources.Male_5121;
                return;

            }
            else
            {
                pbImage.Image = Resources.Female_512;
            }
        }

        private void linkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = "";
        }
    }

}
