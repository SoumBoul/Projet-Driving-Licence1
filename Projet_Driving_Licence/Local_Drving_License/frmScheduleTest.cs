using ClassBusinesLayerDrivingLicense;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet_Driving_Licence
{
    public partial class frmScheduleTest : Form
    {
        clsGlobal global;
        public frmScheduleTest( )
        {
            InitializeComponent();

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmDrivingLicenseInfo fm = Application.OpenForms.OfType<frmDrivingLicenseInfo>().FirstOrDefault();
            int ID = Convert.ToInt32(fm.dgAppointments.CurrentRow.Cells[0].Value);
            TestAppointments test = TestAppointments.FindAppointmentWithTestAppointmentID(ID);
            
            Local_Driving_License_App local = Local_Driving_License_App.Find_LOD_WithLicenseClassID(ID);

            Tests t = new Tests();
           

            int num = 0;


            if (rbPass.Checked)
            {

                test.IsLocked = true;
                t.TestResult = true;
                test.TestTypeID += num;
                cntrScheduleTest2.Date.Enabled = false;
                btnSave.Enabled = false;
            }
            
                if (rbFail.Checked)
                {

                    test.IsLocked = true;
                    t.TestResult = false;
                    cntrScheduleTest2.Date.Enabled = true;
                    btnSave.Enabled = true;




                }
            

            int Iduser= Users.FindUserByName(clsGlobal.name).UserID;
            test.CreatedByUserID = Iduser;
            test.RetakeTestAppointment = test.TestAppointmentID;

            if (test.Save())
            {
                fm = Application.OpenForms.OfType<frmDrivingLicenseInfo>().FirstOrDefault();

                int testApp = Convert.ToInt32(fm.dgAppointments.CurrentRow.Cells[0].Value);


                t.TestAppointmentID = testApp;
                t.CreatedByUserID = Iduser;
                t.Notes = txtNotes.Text;

                if (t.Save())
                {
                    MessageBox.Show("TestResult Saved Successfully");


                    if (t.TestResult == true)
                    {
                        cntrScheduleTest2.Date.Enabled = true;
                        btnSave.Enabled = true;

                    }
                    else
                    {
                        cntrScheduleTest2.Date.Enabled = true;
                        btnSave.Enabled = true;
                    }

                }


            }

            
                else
                {

                MessageBox.Show("Test Not Saved ");

                }

          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
    }
}
