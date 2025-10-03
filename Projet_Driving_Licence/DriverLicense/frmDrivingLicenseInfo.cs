using ClassBusinesLayerDrivingLicense;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;



namespace Projet_Driving_Licence
{
    public partial class frmDrivingLicenseInfo : Form
    {


        clsGlobalResult global = new clsGlobalResult();

        int DrivingID = 0;
        int resulttype = 1;

        public frmDrivingLicenseInfo(int ID)
        {
            InitializeComponent();
            DrivingID = ID;
        }

        private void frmDrivingLicenseInfo_Load(object sender, EventArgs e)
        {

            lblRecord.Text = dgAppointments.RowCount.ToString();

        }

        public bool isHasTest()
        {
            frmScheduleRetakeTests frm = new frmScheduleRetakeTests(DrivingID);
            App app = App.FindApplicationPersonIDWithID(DrivingID);
            frmDrivingLicenseInfo frm1 = new frmDrivingLicenseInfo(DrivingID);

            Local_Driving_License_App local = Local_Driving_License_App.FindApplicationPersonIDWithApplicationID(DrivingID);

            TestAppointments test = TestAppointments.FindTestResult(DrivingID, 1);
            TestAppointments test2 = TestAppointments.FindTestResult(DrivingID, 2);
            TestAppointments test3 = TestAppointments.FindTestResult(DrivingID, 3);
            if (test == null)
            {
                frm.cntrScheduleTest1.lblDL_AppID.Text = cntrDrvingLicenseInformation1.lblDrivingLicenseID.Text;
                frm.cntrScheduleTest1.lblDL_AppID.Text = local.ApplicationID.ToString();
                frm.cntrScheduleTest1.lblD_Class.Text = LicenseClasses.FindApplicationClassWithID(local.LicenseClassID).LicenseClassName;
                frm1.cntrDrvingLicenseInformation1.lblPassedTest.Text = app.PassedTest.ToString() + "/3";
                frm.cntrScheduleTest1.lblFees.Text = "15";
                frm.cntrScheduleTest1.lblName.Text = app.FullName;
                frm.cntrScheduleTest1.lblTrial.Text = "0";



                frm.cntrRetakeTest2.Enabled = false;
                frm.cntrRetakeTest2.lblR_App_Fees.Text = app.PaidFees.ToString();
                frm.cntrRetakeTest2.lblR_TotalFees.Text = frm.cntrScheduleTest1.lblFees.Text;
                frm.cntrRetakeTest2.lbtR_Test_App_Fees.Text = app.ApplicationID.ToString();



                frm.ShowDialog();

            }

            else

            {

                App cntr1 = App.FindApplicationWithID(local.ApplicationID);

                Tests result = Tests.FindTestByTestAppointmentID(test.TestAppointmentID);
                if (app != null && result != null && result.TestResult == true)
                {
                    frm.cntrScheduleTest1.lblDL_AppID.Text = cntrDrvingLicenseInformation1.lblDrivingLicenseID.Text;
                    frm.cntrScheduleTest1.lblDL_AppID.Text = local.ApplicationID.ToString();
                    frm.cntrScheduleTest1.lblD_Class.Text = LicenseClasses.FindApplicationClassWithID(local.LicenseClassID).LicenseClassName;
                    frm1.cntrDrvingLicenseInformation1.lblPassedTest.Text = app.PassedTest.ToString() + "/3";
                    frm.cntrScheduleTest1.lblFees.Text = "15";
                    frm.cntrScheduleTest1.lblName.Text = app.FullName;
                    frm.cntrScheduleTest1.lblTrial.Text = "0";

                    frm.cntrRetakeTest2.Enabled = false;
                    frm.cntrRetakeTest2.lblR_App_Fees.Text = app.PaidFees.ToString();
                    frm.cntrRetakeTest2.lblR_TotalFees.Text = frm.cntrScheduleTest1.lblFees.Text;
                    frm.cntrRetakeTest2.lbtR_Test_App_Fees.Text = app.ApplicationID.ToString();



                    frm.ShowDialog();

                    return true;
                }

            }
        
    

            

            
                frm_Local_Driving_License_App fm = Application.OpenForms.OfType<frm_Local_Driving_License_App>().FirstOrDefault();
               

                if ( test!= null && fm.scheduleVisionTestToolStripMenuItem.Checked  )

                    {
                   
                    
                        if (test.AppointmentDate != null)

                         {
                            MessageBox.Show("This person already has a TestAppointment for tis Test",
                              "Warning",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Stop);
                            return true;

                        }
                    else
                        {
                            frm.cntrScheduleTest1.lblDL_AppID.Text = cntrDrvingLicenseInformation1.lblDrivingLicenseID.Text;
                            frm.cntrScheduleTest1.lblDL_AppID.Text = local.ApplicationID.ToString();
                            frm.cntrScheduleTest1.lblD_Class.Text = LicenseClasses.FindApplicationClassWithID(local.LicenseClassID).LicenseClassName;
                            frm1.cntrDrvingLicenseInformation1.lblPassedTest.Text = app.PassedTest.ToString() + "/3";
                            frm.cntrScheduleTest1.lblFees.Text = "15";
                            frm.cntrScheduleTest1.lblName.Text = app.FullName;
                            frm.cntrScheduleTest1.lblTrial.Text = "0";



                            frm.cntrRetakeTest2.Enabled = false;
                            frm.cntrRetakeTest2.lblR_App_Fees.Text = app.PaidFees.ToString();
                            frm.cntrRetakeTest2.lblR_TotalFees.Text = frm.cntrScheduleTest1.lblFees.Text;
                            frm.cntrRetakeTest2.lbtR_Test_App_Fees.Text = app.ApplicationID.ToString();



                            frm.ShowDialog();

                        }


                }
                if (test2 != null && fm.scheduleWrittenTestToolStripMenuItem.Checked)

                {

                    
                        if (test2.AppointmentDate != null)
                        {
                            MessageBox.Show("This person already has a TestAppointment for tis Test",
                              "Warning",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Stop);
                            return true;

                        }
                    else
                        {
                            frm.cntrScheduleTest1.lblDL_AppID.Text = cntrDrvingLicenseInformation1.lblDrivingLicenseID.Text;
                            frm.cntrScheduleTest1.lblDL_AppID.Text = local.ApplicationID.ToString();
                            frm.cntrScheduleTest1.lblD_Class.Text = LicenseClasses.FindApplicationClassWithID(local.LicenseClassID).LicenseClassName;
                            frm1.cntrDrvingLicenseInformation1.lblPassedTest.Text = app.PassedTest.ToString() + "/3";
                            frm.cntrScheduleTest1.lblFees.Text = "15";
                            frm.cntrScheduleTest1.lblName.Text = app.FullName;
                            frm.cntrScheduleTest1.lblTrial.Text = "0";



                            frm.cntrRetakeTest2.Enabled = false;
                            frm.cntrRetakeTest2.lblR_App_Fees.Text = app.PaidFees.ToString();
                            frm.cntrRetakeTest2.lblR_TotalFees.Text = frm.cntrScheduleTest1.lblFees.Text;
                            frm.cntrRetakeTest2.lbtR_Test_App_Fees.Text = app.ApplicationID.ToString();



                            frm.ShowDialog();

                        }


                   

                }
                if (test3 != null && fm.schduleStreetTestToolStripMenuItem.Checked)

                {
                    
                        if (test3.AppointmentDate != null)
                        {
                            MessageBox.Show("This person already has a TestAppointment for tis Test",
                              "Warning",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Stop);

                            return true;
                        }

                   else
                        {
                            frm.cntrScheduleTest1.lblDL_AppID.Text = cntrDrvingLicenseInformation1.lblDrivingLicenseID.Text;
                            frm.cntrScheduleTest1.lblDL_AppID.Text = local.ApplicationID.ToString();
                            frm.cntrScheduleTest1.lblD_Class.Text = LicenseClasses.FindApplicationClassWithID(local.LicenseClassID).LicenseClassName;
                            frm1.cntrDrvingLicenseInformation1.lblPassedTest.Text = app.PassedTest.ToString() + "/3";
                            frm.cntrScheduleTest1.lblFees.Text = "15";
                            frm.cntrScheduleTest1.lblName.Text = app.FullName;
                            frm.cntrScheduleTest1.lblTrial.Text = "0";



                            frm.cntrRetakeTest2.Enabled = false;
                            frm.cntrRetakeTest2.lblR_App_Fees.Text = app.PaidFees.ToString();
                            frm.cntrRetakeTest2.lblR_TotalFees.Text = frm.cntrScheduleTest1.lblFees.Text;
                            frm.cntrRetakeTest2.lbtR_Test_App_Fees.Text = app.ApplicationID.ToString();



                            frm.ShowDialog();
                        }


                }

                


            
            
            return false;

        }

        public bool IsPassedTest( )
        {
            
            
            TestAppointments test = TestAppointments.FindTestResult(DrivingID, 1);
            TestAppointments test2 = TestAppointments.FindTestResult(DrivingID, 2);
            TestAppointments test3 = TestAppointments.FindTestResult(DrivingID, 3);
          
            frm_Local_Driving_License_App fm = Application.OpenForms.OfType<frm_Local_Driving_License_App>().FirstOrDefault();
            if (test != null  && fm.scheduleVisionTestToolStripMenuItem.Checked   )
            {
                Tests result = Tests.FindTestByTestAppointmentID(test.TestAppointmentID);
                    if (result!=null && result.TestResult== true)

                    { 
                 
                            MessageBox.Show("This person has already passed the test. You can only retake a failed test.",
                                                               "Warning",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Stop);


                            return true;

                        
                    }
                else if (result != null && result.TestResult == false)
                {
                    frmScheduleRetakeTests frm = new frmScheduleRetakeTests(DrivingID);
                    frm.cntrScheduleTest1.Load_DataSchedule(DrivingID);
                    frm.cntrRetakeTest2.Load_RetakeTest(DrivingID);
                    frm.Show();
                    return true;
                }




            }

            if (test2 != null &&fm.scheduleWrittenTestToolStripMenuItem.Checked )

            {

                Tests result = Tests.FindTestByTestAppointmentID(test2.TestAppointmentID);
                
                    if (result != null && result.TestResult == true)

                    {

                        MessageBox.Show("This person has already passed the test. You can only retake a failed test.",
                                                           "Warning",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Stop);


                        return true;


                    }
                else if (result != null && result.TestResult == false)
                {
                    frmScheduleRetakeTests frm = new frmScheduleRetakeTests(DrivingID);
                    frm.cntrScheduleTest1.Load_DataSchedule(DrivingID);
                    frm.cntrRetakeTest2.Load_RetakeTest(DrivingID);
                    frm.Show();
                    return true;
                }
            }

            if (test3 != null && fm.schduleStreetTestToolStripMenuItem.Checked && test3.TestTypeID==3 )

            {

                {
                    Tests result = Tests.FindTestByTestAppointmentID(test3.TestAppointmentID);
                    
                        if (result !=null && result.TestResult == true)

                        {

                            MessageBox.Show("This person has already passed the test. You can only retake a failed test.",
                                                               "Warning",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Stop);


                            return true;


                        }
                    else if (result != null && result.TestResult == false)
                    {
                        frmScheduleRetakeTests frm = new frmScheduleRetakeTests(DrivingID);
                        frm.cntrScheduleTest1.Load_DataSchedule(DrivingID);
                        frm.cntrRetakeTest2.Load_RetakeTest(DrivingID);
                        frm.Show();
                        return true;
                    }
                }

            }

            if (isHasTest())
            {
                return true;
            }


            return false;
        }




        private void ptnAddAppointments_Click(object sender, EventArgs e)
        {
            if (IsPassedTest())
            {
                return;
            }

            

                App app = App.FindApplicationPersonIDWithID(DrivingID);
                frmScheduleRetakeTests frm = new frmScheduleRetakeTests(DrivingID);
                frmDrivingLicenseInfo frm1 = new frmDrivingLicenseInfo(DrivingID);
                Local_Driving_License_App local = Local_Driving_License_App.Find_LOD_WithLicenseClassID(DrivingID);

                App cntr1 = App.FindApplicationWithID(local.ApplicationID);

                if (app != null)
                {
                    frm.cntrScheduleTest1.lblDL_AppID.Text = cntrDrvingLicenseInformation1.lblDrivingLicenseID.Text;
                    frm.cntrScheduleTest1.lblDL_AppID.Text = local.ApplicationID.ToString();
                    frm.cntrScheduleTest1.lblD_Class.Text = LicenseClasses.FindApplicationClassWithID(local.LicenseClassID).LicenseClassName;
                    frm1.cntrDrvingLicenseInformation1.lblPassedTest.Text = app.PassedTest.ToString() + "/3";
                    frm.cntrScheduleTest1.lblFees.Text = cntr1.PaidFees.ToString();
                    frm.cntrScheduleTest1.lblName.Text = app.FullName;
                    frm.cntrScheduleTest1.lblTrial.Text = "0";

                    frm.cntrRetakeTest1.Enabled = true;
                    frm.cntrRetakeTest1.Load_RetakeTest(DrivingID);

                    frm.ShowDialog();
                }
            }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmScheduleRetakeTests frm = new frmScheduleRetakeTests(DrivingID);
            frmScheduleTest frm1 = new frmScheduleTest();
           frm.cntrScheduleTest1.Load_DataSchedule(DrivingID);
           
            frmDrivingLicenseInfo fm = Application.OpenForms.OfType<frmDrivingLicenseInfo>().FirstOrDefault();

            int appointmentid = Convert.ToInt32(fm.dgAppointments.CurrentRow.Cells[0].Value);
            DataTable dt = TestAppointments.GetTestAppointmentWithLocalDrivingID(appointmentid);
            foreach (DataRow row in dt.Rows)
            {
                if(dt.Rows.Count!= 0)
                {
                    Tests num = Tests.FindTestByTestAppointmentID(appointmentid);

                    if (num!=null && num.TestResult == true && Convert.ToBoolean(row["IsLocked"]) == true)
                    {
                        frm.btnSave.Enabled = false;
                        frm.cntrScheduleTest1.Date.Enabled = false;
                        frm1.cntrScheduleTest2.Date.Enabled = false;
                        frm1.btnSave.Enabled = false;
                        frm.Show();
                    }

                    else
                    {
                        frm.btnSave.Enabled = true;
                        frm.cntrScheduleTest1.Date.Enabled = true;
                        frm.cntrRetakeTest2.Load_RetakeTest(DrivingID);
                        frm.cntrRetakeTest2.lbtR_Test_App_Fees.Text = row["TestAppointmentID"].ToString();
                        frm.Show();
                    }
                }
            }


            

        }

        private void takeTestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmScheduleTest frm = new frmScheduleTest();
            
            frm.cntrScheduleTest2.Load_DataSchedule(DrivingID);
            TestAppointments test = TestAppointments.FindAppointmentWithLo_D_L(DrivingID);
            TestTypes type = TestTypes.FindTestApplicationTypes(test.TestTypeID);

            DataTable dt = Tests.GetAllTestsWithAppointmentID(test.TestAppointmentID);
            foreach (DataRow row in dt.Rows)
            {
                bool num = Convert.ToBoolean(row["TestResult"]);
                if (num == true)
                {
                    frm.btnSave.Enabled = true;
                    frm.cntrScheduleTest1.Date.Enabled = true;
                    frm.cntrScheduleTest2.Date.Enabled = true;
                    frm.btnSave.Enabled = true;
                }

                else
                {
                    frm.btnSave.Enabled = true;
                    frm.cntrScheduleTest1.Date.Enabled = true;
                }
            }



            frm.ShowDialog();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
