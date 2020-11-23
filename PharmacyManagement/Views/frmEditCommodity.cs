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

namespace PharmacyManagement.Views
{
    public partial class frmEditCommodity : DevExpress.XtraEditors.XtraForm
    {
        private string recordId;

        private PharmacyDbContext context = PharmacyDbContext.Create();
        private Commodity commodity;
        private List<string> saleUnit;

        public frmEditCommodity()
        {
            InitializeComponent();
        }

        public frmEditCommodity(string recordId) : this() => this.recordId = recordId;

        private void frmEditCommodity_Load(object sender, EventArgs e)
        {
            txbId.Text = "Id: " + recordId;
            commodity = context.Commodities.First(c => recordId == c.Id.ToString());

            txbName.Text = commodity.Name;
            txbProvider.Text = commodity.Provider;
            txbQuantity.Text = commodity.TotalQuantity.ToString();
            txbRefLink.Text = commodity.ReferenceLink?.ToString();
            txbDescription.Text = commodity.Description?.ToString();
            txbBaseUnit.Text = commodity.BaseUnitName?.ToString();
            txbBasePrice.Text = commodity.BaseUnitPrice.ToString();

            saleUnit = context.SaleUnits.Select(u => u.SaleUnitName)?.Distinct().ToList();
            if (saleUnit.Count() > 0)
            {
                cmbSaleUnit.Properties.Items.AddRange(saleUnit);
                cmbSaleUnit.Text = saleUnit[0];
            }
        }

        private void cmbSaleUnit_TextChanged(object sender, EventArgs e)
        {
            if (saleUnit.Contains(cmbSaleUnit.Text))
            {
                var sUnit = context.Commodities
                                        .First(c => recordId == c.Id.ToString())
                                            .SaleUnits
                                            .First(s => s.SaleUnitName.Equals(cmbSaleUnit.Text, StringComparison.OrdinalIgnoreCase));

                txbSalePrice.Text = sUnit?.SaleUnitPrice.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaleUnit sUnit = context.SaleUnits
                                    .FirstOrDefault(s => recordId.Equals(s.CommodityId.ToString()));

                if(sUnit is null)
                {
                    var choice = XtraMessageBox.Show("Từ hồi tạo CSDL tới bây giờ, tôi chưa thấy cái %SaleUnit% nào như cái này. Tạo mới 1 cái nhớ?", "ERROR", MessageBoxButtons.YesNo);
                    if (choice == DialogResult.Yes)
                    {
                        sUnit = new SaleUnit
                        {
                            SaleUnitName = cmbSaleUnit.Text,
                            SaleUnitPrice = decimal.Parse(txbSalePrice.Text),
                            Commodity = commodity
                        };
                    }
                }

                context.SaleUnits.Add(sUnit);

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