using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClassBusinesLayerDrivingLicense;
using static System.Net.Mime.MediaTypeNames;
namespace Projet_Driving_Licence
{
    public partial class Form2 : Form
    {
        
        //public enum enMode { PersonID = 0, NationalNo = 1, FirstName = 2 };
        //enMode _Mode;

        private static DataTable _dtAllPeople = Person.GetAllPeople();

        //only select the columns that you want to show in the grid
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "Gendor", "DateOfBirth", "NationalityCountryID",
                                                         "Phone", "Email");

        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if( cbFilter.Text!="none")
            {
                txtFilterBy.Visible = true;

            }


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dgPeople.DataSource = _dtPeople;
            lblRecord.Text = dgPeople.Rows.Count.ToString();
      

            lblRecord.Text = dgPeople.Rows.Count.ToString();
            if (dgPeople.Rows.Count > 0)
            {

                dgPeople.Columns[0].HeaderText = "Person ID";
                dgPeople.Columns[0].Width = 110;

                dgPeople.Columns[1].HeaderText = "National No";
                dgPeople.Columns[1].Width = 120;


                dgPeople.Columns[2].HeaderText = "First Name";
                dgPeople.Columns[2].Width = 120;

                dgPeople.Columns[3].HeaderText = "Second Name";
                dgPeople.Columns[3].Width = 140;


                dgPeople.Columns[4].HeaderText = "Third Name";
                dgPeople.Columns[4].Width = 120;

                dgPeople.Columns[5].HeaderText = "Last Name";
                dgPeople.Columns[5].Width = 120;

                dgPeople.Columns[6].HeaderText = "Gendor";
                dgPeople.Columns[6].Width = 120;

                dgPeople.Columns[7].HeaderText = "Date Of Birth";
                dgPeople.Columns[7].Width = 140;

                dgPeople.Columns[8].HeaderText = "Nationality";
                dgPeople.Columns[8].Width = 120;


                dgPeople.Columns[9].HeaderText = "Phone";
                dgPeople.Columns[9].Width = 120;


                dgPeople.Columns[10].HeaderText = "Email";
                dgPeople.Columns[10].Width = 170;

            }
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(-1);
            frm.ShowDialog();
            dgPeople.DataSource = Person.GetAllPeople();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void sowDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo((int)dgPeople.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void eToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(-1);
            frm.ShowDialog();

        }

        private void editToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
           
            frmAddNewPerson frm = new frmAddNewPerson((int)dgPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.OK;

            MessageBox.Show("Are You sur do you want to delete this person?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (!Person.DeletePerson((int)dgPeople.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Person was not deleted because he has data linked to it", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (result == DialogResult.OK)
            {
                Person.DeletePerson((int)dgPeople.CurrentRow.Cells[0].Value);

            }


            dgPeople.DataSource = Person.GetAllPeople();
        }

        private void cbFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cbFilter.SelectedIndex!= -1)
            {
                txtFilterBy.Visible = true;

            }
        }

      

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecord.Text = dgPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
               { _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim()); }

            lblRecord.Text = dgPeople.Rows.Count.ToString();

        }
    }

}
