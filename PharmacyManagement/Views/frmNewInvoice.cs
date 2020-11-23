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
using DevExpress.XtraEditors.DXErrorProvider;

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
            txbName.Text = UserIdentity.SessionUser.FullName;

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

            var lstComoditiesName = context.Commodities.Select(it => it.Name)?.ToList();
            if (lstComoditiesName != null)
            {
                cmbCommodities.Properties.Items.AddRange(lstComoditiesName);
                cmbCommodities.Text = lstComoditiesName[0];
            }
            else
            {
                XtraMessageBox.Show("errrrr", "Error");
            }
        }

        DXErrorProvider errorProvider = new DXErrorProvider();
        private void txbQuantity_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;
            try
            {
                int quatity = int.Parse(txbQuantity.Text);
                if (quatity <= 0) throw new Exception("");
            }catch (Exception ex)
            {
                errorProvider.SetError(edit, "Please type the correct quantity (number only)", ErrorType.Critical);
                e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbQuantity.Text!=null&&!txbQuantity.Text.Equals(""))
            listBox1.Items.Add(cmbCommodities.SelectedItem.ToString()+" | "+txbQuantity.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }catch (Exception ex)
            {
                //Not selected any
            }
        }
    }
}