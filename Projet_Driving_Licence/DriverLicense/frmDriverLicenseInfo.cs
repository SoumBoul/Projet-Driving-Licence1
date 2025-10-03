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
    public partial class frmDriverLicenseInfo : Form
    {
        int DrivingID = 0;
        public frmDriverLicenseInfo(int ID)
        {
            InitializeComponent();

            DrivingID = ID;

        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDriverLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
