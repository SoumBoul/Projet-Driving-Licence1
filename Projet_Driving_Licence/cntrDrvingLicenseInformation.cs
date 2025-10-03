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
    public partial class cntrDrvingLicenseInformation : UserControl
    {
        int MyID;
        public cntrDrvingLicenseInformation()
        {
            InitializeComponent();
          
        }

        public void FillDataGirgTestAppointments(int num)
        {
            MyID = num;
            TestAppointments test = TestAppointments.FindAppointmentWithLo_D_L(MyID);

            frmDrivingLicenseInfo frm = new frmDrivingLicenseInfo(MyID);

            // Vérifiez si la DataGridView dispose des colonnes nécessaires
            if (frm.dgAppointments.Columns.Count == 0)
            {
                frm.dgAppointments.Columns.Add("TestAppointmentsID", "Test Appointments ID");
                frm.dgAppointments.Columns.Add("AppointmentDate", "Appointment Date");
                frm.dgAppointments.Columns.Add("PaidFees", "Paid Fees");


                DataGridViewCheckBoxColumn isCheckBoxLocked = new DataGridViewCheckBoxColumn()
                {
                    Name = "IsLocked",
                    HeaderText = "Is Locked",
                    TrueValue = true,
                    FalseValue = false,

                };

                frm.dgAppointments.Columns.Add("IsLocked", "Is Locked");

            }

            // Ajoutez une nouvelle ligne avec les données du test
            frm.dgAppointments.Rows.Add(
            test.TestAppointmentID.ToString(),
                test.AppointmentDate.ToString("yyyy-MM-dd"), // Date au format lisible
                test.PaidFees.ToString("C2"), // Montant formaté en devise
                test.IsLocked   // Affichage lisible pour booléens
            );




        }

        public void Load_Driving_Info(int ID)
        {
            MyID = ID;
            Local_Driving_License_App local = Local_Driving_License_App.Find_LOD_WithLicenseClassID(MyID);
            App cntr = App.FindApplicationPersonIDWithID(MyID);
            App cntr1 = App.FindApplicationWithID(local.ApplicationID);
            AppType type = AppType.FindApplicationTypesByID(cntr1.ApplicationTypeID);
            
             TestAppointments test = TestAppointments.FindAppointmentWithLo_D_L(ID);
          
            if (cntr != null  )
            {
                lblDrivingLicenseID.Text = MyID.ToString();
                lblID.Text =local.ApplicationID.ToString();
                lblClassName.Text = LicenseClasses.FindApplicationClassWithID(local.LicenseClassID).LicenseClassName;
                
                lblPassedTest.Text = 1 +Convert.ToInt32(cntr.PassedTest.ToString()) + "/3"; }
                lblStatus.Text = cntr.Status ;
                lblFees.Text = type.ApplicationFees.ToString();
                lblType.Text = AppType.FindApplicationTypesByID(cntr1.ApplicationTypeID).ApplicationTypeTitle;
                lblApplication.Text = cntr.FullName;
                lblDate.Text = DateTime.Now.ToString();
                lblStatusDate.Text= local.ApplicationDate.ToString();
                lblCreatedBy.Text = clsGlobal.name;

              

            }

        
        private void cntrDrvingLicenseInformation_Load(object sender, EventArgs e)
        {
           
        }

        private void linkPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            int num = Convert.ToInt32(lblID.Text);
            App cntr = App.FindApplicationWithID(num);
            frmPersonInfo frm = new frmPersonInfo(cntr.ApplicationPersonID);

            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
