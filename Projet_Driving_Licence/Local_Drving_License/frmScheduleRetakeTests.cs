using ClassBusinesLayerDrivingLicense;
using System;
using System.Data;
using System.Linq;

using System.Windows.Forms;



namespace Projet_Driving_Licence
{

  
    public partial class frmScheduleRetakeTests : Form
    {

        int Dl_ID;  
        public frmScheduleRetakeTests(int ID)
        {
            InitializeComponent();
            Dl_ID = ID;
           
        }

        private void bntClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmScheduleRetakeTests_Load(object sender, EventArgs e)
        {
            
        }
 
        private void btnSave_Click(object sender, EventArgs e)
        {
            frmScheduleRetakeTests frm1 = new frmScheduleRetakeTests(Dl_ID);
            Local_Driving_License_App local = Local_Driving_License_App.Find_LOD_WithLicenseClassID(Dl_ID);
            App app = App.FindApplicationWithID(local.ApplicationID);

            TestAppointments test = new TestAppointments();

            frm_Local_Driving_License_App fm = Application.OpenForms.OfType<frm_Local_Driving_License_App>().FirstOrDefault();

            if (fm.scheduleVisionTestToolStripMenuItem.Checked == true)
            {
                test.TestTypeID = 1;
            }

            if (fm.scheduleWrittenTestToolStripMenuItem.Checked == true)
            {
                test.TestTypeID = 2;
            }
            if (fm.schduleStreetTestToolStripMenuItem.Checked == true)
            {
                test.TestTypeID = 3;
            }

            test.LocalDrivingLicenseApplicationID = Dl_ID;
                test.AppointmentDate = cntrScheduleTest1.Date.Value;
                test.PaidFees = Convert.ToDecimal(cntrScheduleTest1.lblFees.Text);
                test.CreatedByUserID = Users.FindUserByName(clsGlobal.name).UserID;
                test.IsLocked = false;
                test.RetakeTestAppointment = 0;



            if (test.Save() )
            {
                MessageBox.Show("Data Saved Suuccussffully");

            frmDrivingLicenseInfo fm1 = Application.OpenForms.OfType<frmDrivingLicenseInfo>().FirstOrDefault();
              
            fm1.dgAppointments.Rows.Add( test.TestAppointmentID.ToString(), test.AppointmentDate.ToString("yyyy-MM-dd"), // Date au format lisible
                                     test.PaidFees.ToString("C2"), // Montant formaté en devise
                                     test.IsLocked);  // Affichage lisible pour booléens

                fm1.cntrDrvingLicenseInformation1.Load_Driving_Info(Dl_ID);
                frm1.cntrRetakeTest2.lbtR_Test_App_Fees.Text = test.TestAppointmentID.ToString();
           

                fm1.Show();


            }
            else
                MessageBox.Show("Data NOT Saved ");

        }
    }
}
