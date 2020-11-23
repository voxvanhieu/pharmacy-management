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
using PharmacyManagement.Models.ViewModels;
using PharmacyManagement.Services;

namespace PharmacyManagement.Views
{
    public partial class frmNewInvoice : DevExpress.XtraEditors.XtraForm
    {
        PharmacyDbContext context = PharmacyDbContext.Create();
        UserIdentity userIdentity = new UserIdentity();
        PharmacyBusiness pharmacyBusiness = new PharmacyBusiness();
        private Decimal price { get; set; } = 0;

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
            if (txbQuantity.Text != null && !txbQuantity.Text.Equals("") && textEdit3.Text != null && !textEdit3.Text.Equals("")&&!textEdit2.Text.Equals(""))
            {
                listBox1.Items.Add(cmbCommodities.SelectedItem.ToString() + "|" + txbQuantity.Text + "|" + textEdit2.Text + "|" + textEdit3.Text);
                price += Decimal.Parse(textEdit3.Text);
                textEdit1.Text = "TOTAL: " + price;
            }
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var invoice = new InvoiceViewModel
                {
                    Username = UserIdentity.SessionUser.UserName,
                    Note = txtNote.Text,
                    InvoiceType = cmbInvoideType.SelectedItem.ToString(),
                    Commodities = new List<CommodityViewModel>(),
                    Created=dateBirthday.DateTime
                };

                foreach (string i in listBox1.Items)
                {
                    string[] tmp = i.Split('|');
                    invoice.Commodities.Add(new CommodityViewModel
                    {
                        Name = tmp[0],
                        Quantity = int.Parse(tmp[1]),
                        SaleUnit = tmp[2],
                        SalePrice = Decimal.Parse(tmp[3]),
                    });
                }

                pharmacyBusiness.NewInvoice(invoice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}