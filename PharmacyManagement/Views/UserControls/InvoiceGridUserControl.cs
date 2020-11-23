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

namespace PharmacyManagement.Views.UserControls
{
    public partial class InvoiceGridUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public InvoiceGridUserControl()
        {
            InitializeComponent();
            RefillGrid();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            RefillGrid();
        }

        public void RefillGrid()
        {
            v_InvoiceTableAdapter.Fill(pharmacyDbDataSet.V_Invoice);
        }
    }
}
