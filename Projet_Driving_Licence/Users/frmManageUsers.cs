using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassBusinesLayerDrivingLicense;

namespace Projet_Driving_Licence
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            dgUsers.DataSource = Users.GetAllUsers();
            if(dgUsers.ColumnCount>0)
            {
                dgUsers.Columns["FullName"].Width = 220;
            }

            lblRecord.Text = dgUsers.RowCount.ToString();

        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        
        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "PersonID")
            {
                txtFilterBy.Visible = true;
                int result = Convert.ToInt32(txtFilterBy.Text);
                Users person1 = Users.FindWithPersonID(result);


                dgUsers.DataSource = new List<Users> { person1 };
                return;

            }
            if (cbFilter.Text == "UserID")
            {
                int result = Convert.ToInt32(txtFilterBy.Text);
                Users person2 = Users.Find(result);
                dgUsers.DataSource = new List<Users> { person2 };
                return;

            }
            if (cbFilter.Text == "UserName")
            {

                Users person3 = Users.FindUserByName(txtFilterBy.Text);
                dgUsers.DataSource = new List<Users> { person3 };
                return;

            }

            dgUsers.DataSource = Users.GetAllUsers();


        }


        private void showDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)dgUsers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser(-1);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.OK;

            MessageBox.Show("Are You sur do you want to delete this User?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (!Users.DeleteUser((int)dgUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("User was not deleted because he has data linked to it", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (result == DialogResult.OK)
            {
                Users.DeleteUser((int)dgUsers.CurrentRow.Cells[0].Value);

            }


            dgUsers.DataSource = Users.GetAllUsers();


        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson((int)dgUsers.CurrentRow.Cells[1].Value);


            frm.ShowDialog();
        }

        private void changePassWordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmChangePassWord frm = new frmChangePassWord((int)dgUsers.CurrentRow.Cells[1].Value);

            frm.ShowDialog();
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser(-1);
            frm.ShowDialog();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Filter(string FilterBy)
        {

            DataTable dt = Users.GetAllUsers();

            DataView dv = new DataView(dt );

            if (cbFilter.SelectedIndex == 0  && txtFilterBy.Text== FilterBy && FilterBy!=""  )
            {
                dv.RowFilter = $"UserID='{FilterBy}'";
                dgUsers.DataSource = dv;
                return;

            }
           
             else if (cbFilter.SelectedIndex == 1 && txtFilterBy.Text == FilterBy && FilterBy != "")
                {
                dv.RowFilter = $"PersonID='{FilterBy}'";
                dgUsers.DataSource = dv;
                return;

            }
            else if (cbFilter.SelectedIndex == 2 && txtFilterBy.Text == FilterBy && FilterBy != "")
            {
                dv.RowFilter = $"UserName='{FilterBy}'";
                dgUsers.DataSource = dv;
                return;

            }
            if (cbFilter.SelectedIndex == 3 && txtFilterBy.Text == FilterBy && FilterBy != "")
            {
                dv.RowFilter = $"FullName='{FilterBy}'";
                dgUsers.DataSource = dv;
                return;
            }
            
            else

            {
                dgUsers.DataSource = Users.GetAllUsers();

                dgUsers.Show();
            }




        }


        private void txtFilterBy_TextChanged_1(object sender, EventArgs e)
        {
            Filter(txtFilterBy.Text);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 4)
            {
                cbIsActive.Visible = true;
                if (cbIsActive.SelectedIndex == 0)
                {
                    dgUsers.DataSource = Users.GetAllUsers();
                }

            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
           
        
}
