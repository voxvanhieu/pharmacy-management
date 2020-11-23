using DevExpress.XtraEditors;
using PharmacyManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.Views.UserControls
{
    public partial class CommodityUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public CommodityUserControl()
        {
            InitializeComponent();
            RefillGrid();
        }
        public void RefillGrid()
        {
            v_ComodityTableAdapter.Fill(pharmacyDbDataSet.V_Comodity);
        }

        public string SelectedRowId()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                var row = gridView1.GetSelectedRows()[0];
                return gridView1.GetRowCellValue(row, "Id").ToString();
            }
            else throw new Exception("Pls select 1 row");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            RefillGrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string recordId = SelectedRowId();
            if (recordId == null) return;

            var choice = XtraMessageBox.Show("Sure want to delete this record?", "?? :D ??", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                try
                {
                    using (var context = PharmacyDbContext.Create())
                    {
                        var commodity = new Commodity { Id = int.Parse(recordId) };
                        context.Commodities.Attach(commodity);
                        context.Commodities.Remove(commodity);
                        context.SaveChanges();
                    }
                    XtraMessageBox.Show("Remove successfully", "Pharmacy management");
                    RefillGrid();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Some error occured\nDetails:\n{ex.Message}", "Xome Pug Found");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string recordId = SelectedRowId();
            if (recordId != null) new frmEditCommodity(recordId).ShowDialog();
        }
    }
}
