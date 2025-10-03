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
    public partial class frmManageApplactionTypes : Form
    {
        public frmManageApplactionTypes()
        {
            InitializeComponent();
        }

        public void RefreshApplicationTypes()
        {
            dgApplicationTestTypes.DataSource = AppTypes.GetAllApplicationTypes();
            lblRecord.Text = dgApplicationTestTypes.RowCount.ToString();
            if(dgApplicationTestTypes.Rows.Count>0)
            {
                dgApplicationTestTypes.Columns["ApplicationTypeTitle"].Width = 230;
            }
        }
        private void frmManageApplactionTypes_Load(object sender, EventArgs e)
        {
            RefreshApplicationTypes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationTypes frm = new frmUpdateApplicationTypes((int)dgApplicationTestTypes.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
            RefreshApplicationTypes();

        }
    }
}
