using DevExpress.XtraEditors;
using PharmacyManagement.Models;
using PharmacyManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.Views
{
    public partial class frmEditCommodity : DevExpress.XtraEditors.XtraForm
    {
        private int commodityId;

        private PharmacyDbContext context = PharmacyDbContext.Create();
        private PharmacyBusiness business;

        private Commodity commodity;
        private List<string> saleUnit;

        public frmEditCommodity()
        {
            InitializeComponent();
            business = new PharmacyBusiness(context);
        }

        public frmEditCommodity(string recordId) : this() => this.commodityId = int.Parse(recordId);
        public frmEditCommodity(int recordId) : this() => this.commodityId = recordId;

        private void frmEditCommodity_Load(object sender, EventArgs e)
        {
            txbId.Text = "Id: " + commodityId;
            commodity = context.Commodities.First(c => commodityId == c.Id);

            txbName.Text = commodity.Name;
            txbProvider.Text = commodity.Provider;
            txbQuantity.Text = commodity.TotalQuantity.ToString();
            txbRefLink.Text = commodity.ReferenceLink?.ToString();
            txbDescription.Text = commodity.Description?.ToString();
            txbBaseUnit.Text = commodity.BaseUnitName?.ToString();
            txbBasePrice.Text = commodity.BaseUnitPrice.ToString();

            saleUnit = business.GetListSaleUnitNameOfCommodity(commodityId);
            cmbSaleUnit.Properties.Items.AddRange(saleUnit);
            cmbSaleUnit.SelectedIndex = 0;
        }

        private void cmbSaleUnit_TextChanged(object sender, EventArgs e)
        {
            txbSalePrice.Text = business.GetPriceOfSaleUnit(cmbSaleUnit.Text, commodityId).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (business.CommodityHaveSaleUnit(cmbSaleUnit.Text, commodityId))
                {
                    var choice = XtraMessageBox.Show("Từ hồi tạo CSDL tới bây giờ, tôi chưa thấy cái %SaleUnit% nào như cái này. Tạo mới 1 cái nhớ?", "ERROR", MessageBoxButtons.YesNo);
                    if (choice == DialogResult.Yes)
                        business.AddSaleUnitToCommodity(cmbSaleUnit.Text, decimal.Parse(txbSalePrice.Text), commodityId);
                }

                commodity.Name = txbName.Text;
                commodity.Provider = txbProvider.Text;
                commodity.TotalQuantity = int.Parse(txbQuantity.Text);
                commodity.ReferenceLink = txbRefLink.Text;
                commodity.Description = txbDescription.Text;
                commodity.BaseUnitName = txbBaseUnit.Text;
                commodity.BaseUnitPrice = decimal.Parse(txbBasePrice.Text);

                context.SaveChanges();
                XtraMessageBox.Show("Save successfully");

                context.Dispose();
                context = null;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error");
            }
        }
    }
}