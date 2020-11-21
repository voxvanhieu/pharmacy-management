using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class UserGridControl : DevExpress.XtraEditors.XtraUserControl
    {
        public UserGridControl()
        {
            InitializeComponent();
            RefillGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateDatabase();
            XtraMessageBox.Show("Saved to database successfully!", "Updated", MessageBoxButtons.OK);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
            gridView1.RefreshData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _gridSelectedRowChanged(sender, e);
        }

        public void RefillGrid()
        {
            usersTableAdapter.Fill(pharmacyDbDataSet.Users);
        }

        public void UpdateDatabase()
        {
            usersTableAdapter.Update(pharmacyDbDataSet.Users);
        }

        public string SelectedUsername()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                var row = gridView1.GetSelectedRows()[0];
                return gridView1.GetRowCellValue(row, "UserName").ToString();
            }
            else throw new Exception("Pls select 1 row");
        }
    }
}
