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
    public partial class frmUpdateApplicationTypes : Form
    {
       
        AppTypes application;
        int ApplicationID;
        public frmUpdateApplicationTypes(int ID)
        {
            InitializeComponent();
            ApplicationID = ID;

        }

       
        private void frmUpdateApplicationTypes_Load(object sender, EventArgs e)
        {
            AppTypes application = AppTypes.FindApplicationTypes(ApplicationID);
            if (application != null)
            {
                txtApplicationID.Text = application.ApplicationTypesID.ToString();
                txtTitle.Text = application.Title;
                txtFees.Text = application.ApplicationFees.ToString();



            }

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtApplicationID.Text);
            AppTypes application = AppTypes.FindApplicationTypes(ID);


            application.Title = txtTitle.Text;
            application.ApplicationFees = Convert.ToDecimal(txtFees.Text);


            if (application.Save())
            {
                MessageBox.Show("ApplicationTypes Saved Susccussuffully");


            }

            else
            {
                Console.WriteLine(" ApplicationTypes  NOT Saved ");
            }
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
