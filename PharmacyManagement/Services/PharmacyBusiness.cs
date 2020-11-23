using PharmacyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Services
{
    public class PharmacyBusiness
    {
        private PharmacyDbContext context;
        private bool _disposeContext = false;

        public PharmacyBusiness()
        {
            context = PharmacyDbContext.Create();
        }

        public PharmacyBusiness(PharmacyDbContext context)
        {
            this.context = context;
            _disposeContext = true;
        }

        public bool CommodityHaveSaleUnit(string unitName, int commodityId)
        {
            var commodity = context.Commodities.Find(commodityId);
            if (commodity is null) return false;
            return commodity.SaleUnits
                        .Any(s => s.SaleUnitName.Equals(unitName, StringComparison.OrdinalIgnoreCase));
        }

        public void AddSaleUnitToCommodity(string unitName, decimal unitPrice, int commodityId)
        {
            var saleUnit = context.Commodities.Find(commodityId)?.SaleUnits;
            if (saleUnit is null) { System.Windows.Forms.MessageBox.Show("Commodity id not found"); return; }

            var tmpUnit = saleUnit.FirstOrDefault(s => s.SaleUnitName.Equals(unitName, StringComparison.OrdinalIgnoreCase));
            if (tmpUnit is null)
            {
                saleUnit.Add(new SaleUnit
                {
                    SaleUnitName = unitName,
                    SaleUnitPrice = unitPrice,
                    CommodityId = commodityId,
                });
            }
            else
            {
                tmpUnit.SaleUnitPrice = unitPrice;
            }

            context.SaveChanges();
        }

        public Commodity GetCommodityById(int commodityId)
        {
            return context.Commodities.Find(commodityId);
        }

        public List<string> GetListSaleUnitNameOfCommodity(int commodityId)
        {
            var commodity = context.Commodities.Find(commodityId);
            return (commodity.SaleUnits is null)
                    ? new List<string>()
                    : commodity.SaleUnits
                        .Select(u => u.SaleUnitName)
                        .ToList();
        }

        public decimal GetPriceOfSaleUnit(string unitName, int commodityId)
        {
            var commodity = context.Commodities.Find(commodityId);
            var saleUnit = commodity.SaleUnits.FirstOrDefault(s => s.SaleUnitName.Equals(unitName, StringComparison.OrdinalIgnoreCase));
            return (saleUnit is null) ? 0 : saleUnit.SaleUnitPrice;
        }

        private bool _disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            // Dispose of managed resources here.
            if (disposing)
            {
                if (_disposeContext) context?.Dispose();
            }

            // Dispose of any unmanaged resources not wrapped in safe handles.

            _disposed = true;
        }


    }
}
