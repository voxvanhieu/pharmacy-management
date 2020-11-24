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

            var lstComoditiesUnitName = context.Commodities.Select(it => it.BaseUnitName)?.ToList();
            if (lstComoditiesUnitName != null)
            {
                txtUnitName.Text= lstComoditiesUnitName[0];
            }
            else
            {
                XtraMessageBox.Show("errrrr", "Error");
            }

            var lstComoditiesPrice = context.Commodities.Select(it => it.BaseUnitPrice)?.ToList();
            if (lstComoditiesPrice != null)
            {
                txtUnitPrice.Text = lstComoditiesPrice[0].ToString();
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
                errorProvider.SetError(edit, "");
            }
            catch (Exception ex)
            {
                errorProvider.SetError(edit, "Please type the correct quantity (number only)", ErrorType.Critical);
                e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbQuantity.Text != null && !txbQuantity.Text.Equals("") && txtUnitPrice.Text != null && !txtUnitPrice.Text.Equals("") && !txtUnitName.Text.Equals(""))
                {
                    Boolean flag = false;
                    var lstComoditiesName = context.Commodities.Select(it => it.Name)?.ToList();
                    foreach (string i in lstComoditiesName)
                    {
                        if (cmbCommodities.SelectedItem.ToString().Equals(i))
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) throw new Exception("Not found this commodities in database");
                    listBox1.Items.Add(cmbCommodities.SelectedItem.ToString() + "|" + txbQuantity.Text + "|" + txtUnitName.Text + "|" + txtUnitPrice.Text);
                    price += Decimal.Parse(txtUnitPrice.Text) * Decimal.Parse(txbQuantity.Text);
                    textEdit1.Text = "TOTAL: " + price;
                } else throw new Exception("One or more input is empty, please check again");
            }catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] temp = listBox1.SelectedItem.ToString().Split('|');
                price -= Decimal.Parse(temp[3]) * Decimal.Parse(temp[1]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                textEdit1.Text = "TOTAL: " + price;
            }
            catch (Exception ex)
            {
                //Not selected any
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txbQuantity.Text != null && !txbQuantity.Text.Equals("") && txtUnitPrice.Text != null && !txtUnitPrice.Text.Equals("") && !txtUnitName.Text.Equals("")&&!txtNote.Text.Equals(""))
            {
                try
                {
                    var invoice = new InvoiceViewModel
                    {
                        Username = UserIdentity.SessionUser.UserName,
                        Note = txtNote.Text,
                        InvoiceType = cmbInvoideType.SelectedItem.ToString(),
                        Commodities = new List<CommodityViewModel>(),
                        Created = dateBirthday.DateTime
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
                    context.SaveChanges();
                    pharmacyBusiness.NewInvoice(invoice);
                    MessageBox.Show("Invoice created!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbCommodities_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var lstComoditiesUnitName = context.Commodities.Select(it => it.BaseUnitName)?.ToList();
                if (lstComoditiesUnitName != null)
                {
                    txtUnitName.Text = lstComoditiesUnitName[cmbCommodities.SelectedIndex];
                }
                else
                {
                    XtraMessageBox.Show("errrrr", "Error");
                }

                var lstComoditiesPrice = context.Commodities.Select(it => it.BaseUnitPrice)?.ToList();
                if (lstComoditiesPrice != null)
                {
                    txtUnitPrice.Text = lstComoditiesPrice[cmbCommodities.SelectedIndex].ToString();
                }
                else
                {
                    XtraMessageBox.Show("errrrr", "Error");
                }
            }catch (Exception ex)
            {
                //Not selected any
            }
        }
    }
}