using ClassBusinesLayerDrivingLicense;
using Projet_Driving_Licence.Local_Drving_License;
using System;
using System.Linq;
using System.Windows.Forms;



namespace Projet_Driving_Licence
{

    public partial class PeopleManagement : Form
    {
        clsGlobal global = new clsGlobal();

        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Isactive { get; set; }

        public PeopleManagement()
        {
            InitializeComponent();

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();

        }


        private void PeopleManagement_Load(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frm = new frmManageUsers();
            frm.Show();

        }


        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplactionTypes frm = new frmManageApplactionTypes();

            frm.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocal_Driving_License frm = new frmNewLocal_Driving_License();
            frm.ShowDialog();
        }

        private void loadData(object sender,string username, string password)
        {
            cntrLogin login = new cntrLogin();
            frmLogin frm = new frmLogin();

            UserName = username;

            frm.cntrLogin1.txtUserName.Text = username;
            frm.cntrLogin1.txtPassWord.Text = password;
            frm.cntrLogin1.cbRemmemberMe.Checked = true;

            

            



        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
           // frm.fill_login += loadData;

            frm.Show();




        }

        private void mnageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplactionTypes frm = new frmManageApplactionTypes();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Local_Driving_License_App frm = new frm_Local_Driving_License_App();
          
            frm.ShowDialog();

        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = Users.FindUserByName(clsGlobal.name);

            frmPersonDetails frm = new frmPersonDetails(user.PersonID);

            frm.Show();
           
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = Users.FindUserByName(clsGlobal.name);

            frmChangePassWord frm = new frmChangePassWord(user.PersonID);
            
            frm.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivers frm = new frmManageDrivers();
            
            frm.ShowDialog();

        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplication frm = new frmInternationalLicenseApplication();
            frm.Show();
        }

        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGet_All_International_Licenses_Applications frm = new frmGet_All_International_Licenses_Applications();

            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Renew_License_Application frm = new frm_Renew_License_Application();
           
            frm.Show();


            
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemplacementForDamageLicense frm = new frmRemplacementForDamageLicense();
            frm.Show();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frm_Detain_License frm = new frm_Detain_License();

            
            frm.Show();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelease_Detained_License frm = new frmRelease_Detained_License();

            frm.Show();
        }

        private void relaiseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelease_Detained_License frm = new frmRelease_Detained_License();
            frm.ShowDialog();
        }

        private void relaseTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Local_Driving_License_App frm = new frm_Local_Driving_License_App();
           
            frm.ShowDialog();
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_List_Detained_License frm = new frm_List_Detained_License();
            frm.ShowDialog();
        }
    }
}
