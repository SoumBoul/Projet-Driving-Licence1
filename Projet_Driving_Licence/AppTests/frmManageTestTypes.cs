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
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        public void refreshTestTypes()
        {
            dgApplicationTestTypes.DataSource = TestTypes.GetAllTestApplicationTypes();
            lblRecord.Text = dgApplicationTestTypes.RowCount.ToString();
            if(dgApplicationTestTypes.Rows.Count>0)
            {
                dgApplicationTestTypes.Columns["TestTypeDescription"].Width = 200;
            }
        }
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            refreshTestTypes();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestTypes frm = new frmUpdateTestTypes((int)dgApplicationTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            refreshTestTypes();



        }
    }
}
