using ClassBusinesLayerDrivingLicense;
using System;

using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Projet_Driving_Licence
{
    public partial class frmNewLocal_Driving_License : Form
    {
        clsGlobal global = new clsGlobal();
        enum enMode { AddNew = 0, UpDate = 1 }
        enMode Mode;

        Person _person;


        int ApplicationID = 0;
        //  Users user;
        public frmNewLocal_Driving_License()
        {
            InitializeComponent();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void FillComboboxWithLicenseClass()
        {
            DataTable dt = LicenseClasses.GetAllLicenseClasses();
            foreach (DataRow row in dt.Rows)
            {
                cbLicenseClass.Items.Add(row["ClassName"].ToString());


            }
            cbLicenseClass.SelectedIndex = 0;
        }
        private void frmNewLocal_Driving_License_Load(object sender, EventArgs e)
        {
            FillComboboxWithLicenseClass();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frm_Local_Driving_License_App fm = Application.OpenForms.OfType<frm_Local_Driving_License_App>().FirstOrDefault();
            bool  fm2 = Application.OpenForms.OfType<frm_Local_Driving_License_App>().Any();
            if(fm2 == true)
            {
                MyLicense license = MyLicense.FindLicenseWithLo_D_L((int)fm.dgLocalDriving.CurrentRow.Cells[0].Value);
                if (license != null)
                {
                    MessageBox.Show("Person have already License With Th same Applied Driving Class, Choose different Driving Class  ", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

          

            Local_Driving_License_App _application = new Local_Driving_License_App();

            int ID = Convert.ToInt32(contrPersonInfo1.txtPersonID.Text);
            _person = Person.FindPersonWithID(ID);
            _person = Person.FindPersonWithNationalNo(contrPersonInfo1.txtNationalNo.Text);

            lblTitre.Text = "New Local Driving License ";

            _application = Local_Driving_License_App.Find_LicenseClassFrom_View_WithClassName(_person.NationalNo, cbLicenseClass.Text);
            
            if (_application==null)
            {
                Local_Driving_License_App MyApp = new Local_Driving_License_App();

                MyApp.ApplicationPersonID = Convert.ToInt32(contrPersonInfo1.txtPersonID.Text);
                MyApp.ApplicationTypeID = 1;
                MyApp.ApplicationDate = dpDate.Value;
                MyApp.LicenseClassID = cbLicenseClass.SelectedIndex + 1;
                if(MyApp.LicenseClassID== 3)
                { 
                    MyApp.ApplicationStatus = 3;
                }
                else
                {
                    MyApp.ApplicationStatus = 1;
                }
                MyApp.PaidFees = Convert.ToDecimal(txtApplicationFees.Text);
                MyApp.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;


                App App1 = new App();

                App1 = App.FindApplicationWithNationalNo(_person.NationalNo);
                App1 = MyApp;

                if (App1.Save())
                {

                    //  MessageBox.Show("Data saved successfully");

                }
                MyApp.ClassName = cbLicenseClass.SelectedIndex.ToString();

                App1 = MyApp;


                lblApplicationID.Text = App1.ApplicationID.ToString();
                MyApp.ApplicationID = App1.ApplicationID;
                MyApp.ClassName = cbLicenseClass.SelectedIndex.ToString();


                if (MyApp.Save())
                {
                    MessageBox.Show("Data saved successfully");

                }

                else
                {
                    Console.WriteLine("Date  NOT Saved ");
                }
            }

            else
            {
                
                if (_application.ClassName == cbLicenseClass.Text)
                {
                    MessageBox.Show("Choose another class, the selected User Has already an Active Application for the slected Class", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                _application.ApplicationPersonID = Convert.ToInt32(contrPersonInfo1.txtPersonID.Text);

                _application.ApplicationTypeID = 1;

                _application.ApplicationDate = dpDate.Value;
                _application.LicenseClassID = cbLicenseClass.SelectedIndex + 1;
                if (_application.LicenseClassID == 3)
                {
                    _application.ApplicationStatus = 3;
                }
                else
                {
                    _application.ApplicationStatus = 1;
                }
                
                _application.PaidFees = Convert.ToDecimal(txtApplicationFees.Text);
                _application.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;


                App app = new App();
                app = App.FindApplicationWithNationalNo(_person.NationalNo);
                app = _application;

                if (app.Save())
                {

                    //  MessageBox.Show("Data saved successfully");

                }


                _application.ClassName = cbLicenseClass.SelectedIndex.ToString();

                app = _application;
                lblApplicationID.Text = app.ApplicationID.ToString();
                _application.ApplicationID = app.ApplicationID;
                _application.ClassName = cbLicenseClass.SelectedIndex.ToString();


                if (_application.Save())
                {
                    MessageBox.Show("Data saved successfully");

                }

                else
                {
                    Console.WriteLine("Date  NOT Saved ");
                }
            }  
      
        }


        public  void Searsh_Data()
        {

            
            string name = txtFilterBy.Text;
            App local = App.FindApplicationWithNationalNo(name);

            cbLicenseClass.Text = local.ClassName;
            lblApplicationID.Text = local.Lo_D_L.ToString();
            txtApplicationFees.Text = "15";
            txtCreatedBY.Text = clsGlobal.name;


        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            contrPersonInfo1.LoadMy_data(txtFilterBy.Text);
            string name = txtFilterBy.Text;
            App local = App.FindApplicationWithNationalNo(name);

            if (local != null)
            {
                cbLicenseClass.Text = local.ClassName;
                lblApplicationID.Text = local.Lo_D_L.ToString();
                txtApplicationFees.Text = "15";
                txtCreatedBY.Text = clsGlobal.name;
            }
            else
            {
                cbLicenseClass.Text = "";
                lblApplicationID.Text = "";
                txtApplicationFees.Text = "15";
                txtCreatedBY.Text = clsGlobal.name;
            }
           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
        private void Load_Data(object sender, int personID, string nationalNo, string firstName, string secondname, string thirdname,
           string lastname, string dateofbirth, bool gendor, string address, string phone, string email, int nationalitycountryID, string imagepath)
        {

            contrPersonInfo1.txtPersonID.Text = personID.ToString();
            contrPersonInfo1.txtNationalNo.Text = nationalNo;
            contrPersonInfo1.txtName.Text = firstName+" "+ secondname+" "+thirdname+" "+lastname;
            contrPersonInfo1.txtDateOfBirth.Text = dateofbirth.ToString();
            if(gendor== false)
            {
                contrPersonInfo1.txtGendor.Text = "Female";
            }
            else
            {
                contrPersonInfo1.txtGendor.Text = "Male";
            }
            contrPersonInfo1.txtAddress.Text = address;
            contrPersonInfo1.txtPhone.Text = phone;
            contrPersonInfo1.txtEmail.Text = email;
            contrPersonInfo1.cbCountries.Text = nationalitycountryID.ToString();
            contrPersonInfo1.MypbImage.ImageLocation = imagepath;
            txtCreatedBY.Text = clsGlobal.name;

            
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            frmAddNewPerson frm = new frmAddNewPerson(-1);
            frm.Load_PersonData += Load_Data;
            frm.ShowDialog();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.TabIndex + 1;
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
