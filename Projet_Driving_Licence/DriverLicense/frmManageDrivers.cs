using System;
using ClassBusinesLayerDrivingLicense;
using System.Windows.Forms;
using System.ComponentModel;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;

namespace Projet_Driving_Licence.Local_Drving_License
{
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            dgListDrivers.DataSource = Driver.GetAllDrivers();
            if(dgListDrivers.ColumnCount>0)
            {
                dgListDrivers.Columns["FullName"].Width = 250;
                dgListDrivers.Columns["ActiveLicenses"].Width = 125;

            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Filter(string name)
        {
            DataTable dt = Driver.GetAllDrivers();
            DataView dv = new DataView(dt);
            
           
                if (cbFilterBy.Text == "NationalNo" && txtFilterBy.Text == name && name != "")
                {
                    dv.RowFilter = $" NationalNo= '{name}'";
               
                    dgListDrivers.DataSource = dv;
                    dgListDrivers.Show();
                    return;
                   

                }
              else if (cbFilterBy.Text == "PersonID" && txtFilterBy.Text == name && name != "")
              {
                
                dv.RowFilter = $" PersonID= '{name}'";
                dgListDrivers.DataSource = dv;
                dgListDrivers.Show();
                return;

              }
             else if (cbFilterBy.Text == "DriverID" && txtFilterBy.Text == name && name!="")
             {
               
                 dv.RowFilter = $" DriverID= '{name}'";
                 dgListDrivers.DataSource = dv;
                 dgListDrivers.Show();
                 return;
           

             }
             else if (cbFilterBy.Text == "FullName" && txtFilterBy.Text == name && name != "")
             {
                dv.RowFilter = $" FullName= '{name}'";
                dgListDrivers.DataSource = dv;
                dgListDrivers.Show();
                return;

             }
             else if (cbFilterBy.Text == "ActiveLicense" && txtFilterBy.Text == name && name != "")
             {
                dv.RowFilter = $" ActiveLicense= '{name}'";
                dgListDrivers.DataSource = dv;
                dgListDrivers.Show();
                return;

             }

            else
            {
                dgListDrivers.DataSource = Driver.GetAllDrivers();
                dgListDrivers.Show();
            }
            

        }
      
        private void txtFilterBy_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            Filter(txtFilterBy.Text);
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPersonInfo frm = new frmPersonInfo((int)dgListDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


    }
    
}
