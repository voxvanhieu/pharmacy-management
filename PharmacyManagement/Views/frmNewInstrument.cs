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
    public partial class frmNewInstrument : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyBusiness business = new PharmacyBusiness();

        public frmNewInstrument()
        {
            InitializeComponent();
        }

        private void frmNewInstrument_Load(object sender, EventArgs e)
        {
            cmbTypeInstrument.Properties.Items.AddRange(business.GetAllCommodityType());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var commodity = new Commodity
            {
                Name = txbName.Text,
                Provider = txbProvider.Text,
                TotalQuantity = int.Parse(txbQuantity.Text),
                ReferenceLink = txbRefLink.Text,
                Description = txbDescription.Text,
                BaseUnitName = txbBaseUnit.Text,
                BaseUnitPrice = decimal.Parse(txbBasePrice.Text)
            };

            try
            {
                business.NewCommodity(commodity, cmbTypeInstrument.Text);
                XtraMessageBox.Show("Create new commodity successfully", "ERROR");
                business.Dispose();
                business = null;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR");
            }
        }
    }
}