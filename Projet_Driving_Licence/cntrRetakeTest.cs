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
using static System.Net.Mime.MediaTypeNames;

namespace Projet_Driving_Licence
{
    public partial class cntrRetakeTest : UserControl
    {
        
        public cntrRetakeTest()
        {
            InitializeComponent();
        }

        public  void Load_RetakeTest(int ID)
        {

            //TestAppointments app1 = TestAppointments.FindAppointmentWithLo_D_L(ID);
            cntrScheduleTest cntr = new cntrScheduleTest();
            cntr.Load_DataSchedule(ID);


            this.Enabled = true;
            this.lblR_App_Fees.Text = cntr.lblFees.Text;

            int num1 = Convert.ToInt32(lblR_App_Fees.Text);
            int num2 = Convert.ToInt32(cntr.lblFees.Text);
            this.lblR_TotalFees.Text = (num1 + num2).ToString();




        }


    }
}
