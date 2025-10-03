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
    public partial class frmUpdateTestTypes : Form
    {
        int TestID;
        public frmUpdateTestTypes(int ID)
        {
            InitializeComponent();
            TestID = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(txtTestApplicationID.Text);
            TestTypes Test = TestTypes.FindTestApplicationTypes(ID);


            Test.TestTypeTitle = txtTestTitle.Text;
            Test.TestTypeDescription = txtTestDescription.Text;
            Test.TestTypeFees = Convert.ToDecimal(txtFees.Text);


            if (Test.Save())
            {
                MessageBox.Show("Test Application Type Saved Susccussuffully");


            }

            else
            {
                Console.WriteLine(" Test Application Type  NOT Saved ");
            }


        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
           
            
            TestTypes Test = TestTypes.FindTestApplicationTypes(TestID);
                if (Test != null)
                {
                    txtTestApplicationID.Text = Test.TestTypeID.ToString();
                    txtTestTitle.Text = Test.TestTypeTitle;
                    txtTestDescription.Text = Test.TestTypeDescription;
                    txtFees.Text = Test.TestTypeFees.ToString();



                }
            }
    }
}
