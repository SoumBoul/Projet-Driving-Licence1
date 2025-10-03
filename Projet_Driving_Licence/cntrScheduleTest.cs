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
    public partial class cntrScheduleTest : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1, Cancel = 2 };
        enMode Mode;

        public cntrScheduleTest()
        {
            InitializeComponent();
        }

        public void Load_DataSchedule(int Dl_ID)
        {

           
            frmScheduleRetakeTests frm = new frmScheduleRetakeTests(Dl_ID);
            TestAppointments Test = TestAppointments.FindAppointmentWithLo_D_L(Dl_ID);
            //DataTable dt = TestAppointments.GetTestAppointmentWithLocalDrivingID(Dl_ID);
            App app = App.FindApplicationPersonIDWithID(Dl_ID);
            //cntrDrvingLicenseInformation cntr = new cntrDrvingLicenseInformation();
            
                if (Test!=null)
                {
                    lblDL_AppID.Text = Dl_ID.ToString();
                    lblD_Class.Text = app.ClassName;
                    lblName.Text = app.FullName;
                    lblTrial.Text = (Convert.ToInt32(lblTrial.Text) + 1).ToString();
                    Date.Value = Convert.ToDateTime(Test.AppointmentDate);
                    lblFees.Text = "15";
                    frm.cntrRetakeTest1.lblTotalFees.Text += Test.PaidFees;
                    frm.cntrRetakeTest1.lblR_App_Fees.Text = app.ApplicationID.ToString();
                    frm.cntrRetakeTest2.lbtR_Test_App_Fees.Text = Test.TestAppointmentID.ToString();




                }
               
            }




        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
