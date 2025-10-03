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
    public partial class cntrLogin : UserControl
    {
       
       public  string userName { get; set; }
       public string PassWord { get; set; }
        public string RemmemberMe { get; set; }
        public cntrLogin()
        {
            InitializeComponent();
        }

      
        public void  Mylogin()
        {
           

        }

         public   void LoadDataLogin()
        {
           
            if(clsGlobal.RemmemberMe == true)
             {
                txtUserName.Text= clsGlobal.name;
                txtPassWord.Text = clsGlobal.pass;
                cbRemmemberMe.Checked = clsGlobal.RemmemberMe;
            }
            else
            {
                txtUserName.Text = "";
                txtPassWord.Text = "";
                cbRemmemberMe.Checked = false;
            }
        


        }
        public void cntrLogin_Load(object sender, EventArgs e)
        {
            LoadDataLogin();



        }
    }
}
