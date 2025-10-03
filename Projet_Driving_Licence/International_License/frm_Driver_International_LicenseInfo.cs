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
    public partial class frm_Driver_International_LicenseInfo : Form
    {
        int LicenseID;
        public frm_Driver_International_LicenseInfo(int ID)
        {
            InitializeComponent();
            LicenseID = ID;
        }

        private void frm_Driver_International_LicenseInfo_Load(object sender, EventArgs e)
        {

            cntr_Drver_Int_License_Info1.Fill_Driver_License_Info(LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
