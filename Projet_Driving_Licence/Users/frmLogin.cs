using System;
using System.Windows.Forms;
using System.Xml.Linq;
using ClassBusinesLayerDrivingLicense;

namespace Projet_Driving_Licence
{

    public partial class frmLogin : Form
    {

        public string UserName { get; set; } 
        public string PassWord { get; set; }
        public bool IsActive { get; set; }
         
        public frmLogin()
        {
            InitializeComponent();


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            UserName = cntrLogin1.txtUserName.Text;
            PassWord = cntrLogin1.txtPassWord.Text;

        }
        public void Load_Login(string   name, string PassWord, bool remmember)
            {

            
             Users user1 = Users.FindUserByName(name);
            if ( user1==null || name!= user1.UserName|| PassWord!= user1.PassWord  )
            {
                MessageBox.Show("Invalid UserName/PassWord");
                return;
            }
            if(user1.IsActive != true)
            {
                MessageBox.Show("you are InActive, Contact your Admin");
                return;
            }
            string MyName = cntrLogin1.txtUserName.Text;
            string MyPassWord = cntrLogin1.txtPassWord.Text;
            remmember = cntrLogin1.cbRemmemberMe.Checked;

            clsGlobal.name = MyName;
            clsGlobal.pass = MyPassWord;
            clsGlobal.RemmemberMe = remmember;
            
            PeopleManagement frm = new PeopleManagement();

             frm.Show();

        }


        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            Load_Login(cntrLogin1.txtUserName.Text, cntrLogin1.txtPassWord.Text, cntrLogin1.cbRemmemberMe.Checked);

        }
    }
}
