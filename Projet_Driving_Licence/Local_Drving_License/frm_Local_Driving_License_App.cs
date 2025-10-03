using System;
using System.ComponentModel;
using System.Data;

using System.Windows.Forms;
using ClassBusinesLayerDrivingLicense;




namespace Projet_Driving_Licence
{
    public partial class frm_Local_Driving_License_App : Form
    {

        public enum enMode { Vision = 0, Written = 1 }
        enMode Mode;
        clsGlobalResult global = new clsGlobalResult();

        public frm_Local_Driving_License_App()
        {
            InitializeComponent();
        }

        private void RefreshDgDrivingLicense()
        {
            dgLocalDriving.DataSource = Local_Driving_License_App.GetAllDrivingLicenseFrom_View();
            if (dgLocalDriving.ColumnCount > 0)
            {
                dgLocalDriving.Columns["ClassName"].Width = 220;
                dgLocalDriving.Columns["FullName"].Width = 220;
            }

            lblRecord.Text = dgLocalDriving.RowCount.ToString();

        }
        private void frm_Local_Driving_License_Applications_Load(object sender, EventArgs e)
        {
            RefreshDgDrivingLicense();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            RefreshDgDrivingLicense();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            frmNewLocal_Driving_License frm = new frmNewLocal_Driving_License();
            frm.Show();

        }

        private void cancelledApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person _person = new Person();
            int ID = (int)dgLocalDriving.CurrentRow.Cells[0].Value;

            Local_Driving_License_App Lo_D_L = Local_Driving_License_App.Find_LOD_WithLicenseClassID(ID);
            if (Lo_D_L != null)
            {

            }

            App _application = App.FindApplicationWithID(Lo_D_L.ApplicationID);

            _application.ApplicationID = Lo_D_L.ApplicationID;
            _application.ApplicationTypeID = Lo_D_L.ApplicationTypeID;
            _application.ApplicationPersonID = _application.ApplicationPersonID;
            _application.ApplicationDate = DateTime.Now;
            _application.ApplicationTypeID = 1;
            _application.ApplicationStatus = 2;
            _application.PaidFees = 15;
            _application.CreatedByUserID = 1;


            if (_application.Save())
            {
                MessageBox.Show("Bravo, Data cancelled ");

            }
            else
                MessageBox.Show("sorry, Data cancelled ");


            RefreshDgDrivingLicense();

        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocal_Driving_License frm = new frmNewLocal_Driving_License();
            frm.contrPersonInfo1.LoadMy_data(dgLocalDriving.CurrentRow.Cells[2].Value.ToString());
            frm.ShowDialog();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.OK;

            MessageBox.Show("Are You sur do you want to delete this Application?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (!App.DeleteApplications((int)dgLocalDriving.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Application was not deleted because he has data linked to it", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (result == DialogResult.OK)
            {
                App.DeleteApplications((int)dgLocalDriving.CurrentRow.Cells[0].Value);

            }


            dgLocalDriving.DataSource = Local_Driving_License_App.GetAllDrivingLicenseFrom_View();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocal_Driving_License frm = new frmNewLocal_Driving_License();
            frm.contrPersonInfo1.LoadMy_data(dgLocalDriving.CurrentRow.Cells[2].Value.ToString());

            string name = dgLocalDriving.CurrentRow.Cells[2].Value.ToString();
           
            App local = App.FindApplicationWithNationalNo(name);
          
            frm.cbLicenseClass.Text = dgLocalDriving.CurrentRow.Cells[1].Value.ToString();
            frm.lblApplicationID.Text = local.Lo_D_L.ToString();
            frm.txtApplicationFees.Text = "15";
            frm.txtCreatedBY.Text = clsGlobal.name;


            frm.ShowDialog();
        }
        public void Filter(string FilterBy)
        {

            DataTable dt = Local_Driving_License_App.GetAllDrivingLicenseFrom_View();

            DataView dv = new DataView(dt);

            if (cbFilter.SelectedIndex == 0 && txtFilterBy.Text == FilterBy && FilterBy!="")
            {
                dv.RowFilter = $"LocalDrivingLicenseApplicationID='{FilterBy}'";
                dgLocalDriving.DataSource = dv;
                return;

            }
            else if (cbFilter.SelectedIndex == 1 && txtFilterBy.Text == FilterBy && FilterBy != "")
            {
                dv.RowFilter = $"ClassName='{FilterBy}'";
                dgLocalDriving.DataSource = dv;
                return;

            }

            else if (cbFilter.SelectedIndex == 2 && txtFilterBy.Text == FilterBy && FilterBy != "")
            {
                dv.RowFilter = $"NationalNo='{FilterBy}'";
                dgLocalDriving.DataSource = dv;
                return;

            }
            else if (cbFilter.SelectedIndex == 3 && txtFilterBy.Text == FilterBy && FilterBy != "")
            {
                dv.RowFilter = $"FullName='{FilterBy}'";
                dgLocalDriving.DataSource = dv;
                return;
            }
            else if (cbFilter.SelectedIndex == 4 && txtFilterBy.Text == FilterBy && FilterBy != "")
            {
                dv.RowFilter = $"ApplicationDate='{FilterBy}'";
                dgLocalDriving.DataSource = dv;
                return;

            }
            else if (cbFilter.SelectedIndex == 5 && txtFilterBy.Text == FilterBy && FilterBy != "")
            {
                dv.RowFilter = $"PassedTestCount='{FilterBy}'";
                dgLocalDriving.DataSource = dv;
                return;

            }
            else if (cbFilter.SelectedIndex == 6 && txtFilterBy.Text == FilterBy && FilterBy != "")
            {
                dv.RowFilter = $"status='{FilterBy}'";
                dgLocalDriving.DataSource = dv;
                return;

            }
            else
            {
                dgLocalDriving.DataSource = Local_Driving_License_App.GetAllDrivingLicenseFrom_View();
                dgLocalDriving.Show();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            Filter(txtFilterBy.Text.ToString());
        }
        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDrivingLicenseInfo frm = new frmDrivingLicenseInfo((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            DataTable dt = TestAppointments.GetTestAppointment((int)dgLocalDriving.CurrentRow.Cells[0].Value,1);

            frm.cntrDrvingLicenseInformation1.Load_Driving_Info((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            frm.lblTitre.Text = "Test Vision Appointments";
           
                if (dt != null)
                {
                    for(int i=dt.Rows.Count -1; i >=0; i--)
                   {
                        DataRow row = dt.Rows[i];
                        frm.dgAppointments.Rows.Add(
                    row["TestAppointmentID"].ToString(),
                    row["AppointmentDate"], // Date au format lisible
                    row["PaidFees"], // Montant formaté en devise
                    row["IsLocked"]  // Affichage lisible pour booléens
                 );
                

                }
               

            }
            frm.Show();


        }


        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivingLicenseInfo frm = new frmDrivingLicenseInfo((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            DataTable dt = TestAppointments.GetTestAppointment((int)dgLocalDriving.CurrentRow.Cells[0].Value, 2);

            frm.cntrDrvingLicenseInformation1.Load_Driving_Info((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            frm.lblTitre.Text = "Test Written Appointments";
            if (dt != null)
            {
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = dt.Rows[i];
                    frm.dgAppointments.Rows.Add(
                row["TestAppointmentID"].ToString(),
                row["AppointmentDate"], // Date au format lisible
                row["PaidFees"], // Montant formaté en devise
                row["IsLocked"]  // Affichage lisible pour booléens
             );
            
                   

            }
                frm.Show();


            }

            
        }

        private void schduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivingLicenseInfo frm = new frmDrivingLicenseInfo((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            DataTable dt = TestAppointments.GetTestAppointment((int)dgLocalDriving.CurrentRow.Cells[0].Value, 3);

            frm.cntrDrvingLicenseInformation1.Load_Driving_Info((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            frm.lblTitre.Text = "Test Street Appointments";
            if (dt != null)
            {
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = dt.Rows[i];
                    frm.dgAppointments.Rows.Add(
                row["TestAppointmentID"].ToString(),
                row["AppointmentDate"], // Date au format lisible
                row["PaidFees"], // Montant formaté en devise
                row["IsLocked"]  // Affichage lisible pour booléens
             );
            
                  
             }

                frm.Show();

            }

        }


        private void scheduToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
           
            DataTable dt = TestAppointments.GetTestAppointmentWithLocalDrivingID((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            if (dt.Rows.Count == 0 )
            {
                this.scheduleVisionTestToolStripMenuItem.Enabled = true;
                this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
                this.schduleStreetTestToolStripMenuItem.Enabled = false;

                return;
            }

            if (dt != null)
            {

                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {


                    DataRow row = dt.Rows[i];
                   
                        Tests Result = Tests.FindTestByTestAppointmentID(Convert.ToInt32(row["TestAppointmentID"]));
                    if (Result!= null )
                    {
                        if (Result.TestResult == false && Convert.ToInt32(row["TestTypeID"]) == 1)
                        {
                            this.scheduleVisionTestToolStripMenuItem.Enabled = true;
                            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
                            this.schduleStreetTestToolStripMenuItem.Enabled = false;
                            return;

                        }
                        else if (Result.TestResult == true && Convert.ToInt32(row[1]) == 1)
                        {
                            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
                            this.scheduleWrittenTestToolStripMenuItem.Enabled = true;
                            this.schduleStreetTestToolStripMenuItem.Enabled = false;
                            return;
                        }
                        else if (Result.TestResult == false && Convert.ToInt32(row[1]) == 2)
                        {
                            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
                            this.scheduleWrittenTestToolStripMenuItem.Enabled = true;
                            this.schduleStreetTestToolStripMenuItem.Enabled = false;
                            return;
                        }
                        else if (Result.TestResult == true && Convert.ToInt32(row[1]) == 2)
                        {
                            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
                            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
                            this.schduleStreetTestToolStripMenuItem.Enabled = true;
                            return;

                        }
                        else if (Result.TestResult == false && Convert.ToInt32(row[1]) == 3)
                        {
                            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
                            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
                            this.schduleStreetTestToolStripMenuItem.Enabled = true;
                            return;
                        }
                        else if (Result.TestResult == true && (Convert.ToInt32(row[1]) == 3))
                        {
                            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
                            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
                            this.schduleStreetTestToolStripMenuItem.Enabled = false;
                            return;
                        }

                    }
                    else
                    {
                        this.scheduleVisionTestToolStripMenuItem.Enabled = true;
                        this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
                        this.schduleStreetTestToolStripMenuItem.Enabled = false;
                        return;

                    }
                }
            }
        }
        


        private void contextMenuStrip2_Opened(object sender, EventArgs e)
        {
            
            DataTable local = Local_Driving_License_App.GetAllDrivingLicenseFrom_View1((int)dgLocalDriving.CurrentRow.Cells[0].Value);
          
           
            foreach (DataRow row1 in local.Rows)
            {
                if (local != null && Convert.ToInt32(row1[5]) ==3)

                {
                    this.scheduToolStripMenuItem.Enabled = false;
                    this.issueDrivingLicenseFirsTimeToolStripMenuItem.Enabled = true;
                }
                else
                {
                    this.scheduToolStripMenuItem.Enabled = true;
                    this.issueDrivingLicenseFirsTimeToolStripMenuItem.Enabled = false;
                }
            }
           
           if( MyLicense.IsLicenseExist((int)dgLocalDriving.CurrentRow.Cells[0].Value ) && (int)dgLocalDriving.CurrentRow.Cells[5].Value == 3)
            {
                this.editToolStripMenuItem.Enabled = false;
                this.editToolStripMenuItem.Enabled = false;
                this.delToolStripMenuItem.Enabled = false;
                this.cancelledApplicationToolStripMenuItem.Enabled = false;
                this.scheduToolStripMenuItem.Enabled = false;
                this.issueDrivingLicenseFirsTimeToolStripMenuItem.Enabled = true;
                this.showLicenseToolStripMenuItem.Enabled = true;
                this.showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
            }
           else

            {
                this.editToolStripMenuItem.Enabled = true;
                this.editToolStripMenuItem.Enabled = true;
                this.delToolStripMenuItem.Enabled = true;
                this.cancelledApplicationToolStripMenuItem.Enabled = true;
                this.scheduToolStripMenuItem.Enabled = true;
                this.issueDrivingLicenseFirsTimeToolStripMenuItem.Enabled = false;
                this.showLicenseToolStripMenuItem.Enabled = false;
                this.showPersonLicenseHistoryToolStripMenuItem.Enabled = true;

            }

        }

        private void issueDrivingLicenseFirsTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDrivingLicense frm = new frmIssueDrivingLicense((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            cntrDrvingLicenseInformation info = new cntrDrvingLicenseInformation();
            frm.cntrDrvingLicenseInformation1.Load_Driving_Info((int)dgLocalDriving.CurrentRow.Cells[0].Value);

            frm.ShowDialog();


        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            frm.cntrDriverLiceseInfo11.Load_DrivingLicense_With_LicenseID_InfoWith_LoD_L((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            
            frm.ShowDialog();
        }

        private void scheduToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory((int)dgLocalDriving.CurrentRow.Cells[0].Value);

            MyLicense license = MyLicense.FindLicenseWithLo_D_L((int)dgLocalDriving.CurrentRow.Cells[0].Value);
            frm.contrPersonInfo1.LoadMy_data((string)dgLocalDriving.CurrentRow.Cells[2].Value);

         
            if(license.DriverID == -1)
            {
                return;
            }
            if( license.DriverID!= -1)
            {DataTable dt = MyLicense.Get_AllLicenses(license.DriverID);
                if (dt != null)
                {
                    string ClassName = LicenseClasses.FindApplicationClassWithID(license.LicenseClass).LicenseClassName;
                    foreach (DataRow row in dt.Rows)
                    {
                        frm.dgLicense.Rows.Add(row["LicenseID"], row["ApplicationID"], ClassName, row["IssueDate"],
                     row["ExpirationDate"], row["IsActive"]);
                    }
                }
            }

            else
            {
                string ClassName = LicenseClasses.FindApplicationClassWithID(license.LicenseClass).LicenseClassName;
               
                    frm.dgLicense.Rows.Add(license.LicenseID, license. ApplicationID, ClassName, license.IssueDate,
                 license.ExpirationDate, license.IsActive);
                
            }

            InternationalLicense internationalLicense = InternationalLicense.Find_International_License(license.LicenseID);

            if(internationalLicense!=null)
            {
                frm.dg_int_License.Rows.Add(internationalLicense.InternationalLicenseID, internationalLicense.ApplicationID, internationalLicense.IssuedUsingLocalLicenseID, internationalLicense.IssueDate,
            license.ExpirationDate, license.IsActive);

            }


            frm.ShowDialog();
        }
    }
}
    


    
