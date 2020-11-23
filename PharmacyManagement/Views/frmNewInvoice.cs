using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PharmacyManagement.Models;

namespace PharmacyManagement.Views
{
    public partial class frmNewInvoice : DevExpress.XtraEditors.XtraForm
    {
        PharmacyDbContext context = PharmacyDbContext.Create();
        UserIdentity userIdentity = new UserIdentity();

        public frmNewInvoice()
        {
            InitializeComponent();
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void frmNewInvoice_Load(object sender, EventArgs e)
        {

            var lstInvoiceType = context.InvoiceTypes.Select(it => it.Name)?.ToList();
            if (lstInvoiceType != null)
            {
                cmbInvoideType.Properties.Items.AddRange(lstInvoiceType);
                cmbInvoideType.Text = "Sale";
            }
            else
            {
                XtraMessageBox.Show("errrrr", "Error");
            }
        }
    }
}