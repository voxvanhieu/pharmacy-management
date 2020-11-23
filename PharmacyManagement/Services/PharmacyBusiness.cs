using PharmacyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Services
{
    public class PharmacyBusiness : IDisposable
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

        public void NewCommodity(Commodity commodity, string typeName)
        {
            try
            {
                NewCommodity(commodity, new CommodityType { Name = typeName });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void NewCommodity(Commodity commodity, CommodityType type)
        {
            if (string.IsNullOrWhiteSpace(type.Name))
                type = context.CommodityTypes.First(ct => ct.Name == "Other");
            else if (context.CommodityTypes.Any(t => t.Name.Equals(type.Name)))
                type = context.CommodityTypes.First(t => t.Name.Equals(type.Name));
            else
                type = context.CommodityTypes.Add(type);

            commodity = context.Commodities.Add(commodity);
            type.Commodities.Add(commodity);

            context.SaveChanges();
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

        public List<string> GetAllSaleUnitNameOfCommodity(int commodityId)
        {
            var commodity = context.Commodities.Find(commodityId);
            return (commodity.SaleUnits is null)
                    ? new List<string>()
                    : commodity.SaleUnits
                        .Select(u => u.SaleUnitName)
                        .ToList();
        }
        public List<string> GetAllCommodityType()
        {
            return context.CommodityTypes.Select(ct => ct.Name).ToList();
        }

        public decimal GetPriceOfSaleUnit(string unitName, int commodityId)
        {
            var commodity = context.Commodities.Find(commodityId);
            var saleUnit = commodity.SaleUnits.FirstOrDefault(s => s.SaleUnitName.Equals(unitName, StringComparison.OrdinalIgnoreCase));
            return (saleUnit is null) ? 0 : saleUnit.SaleUnitPrice;
        }

        public bool RemoveCommodity(int commodityId)
        {
            try
            {
                var commodity = context.Commodities.Find(commodityId);
                if (commodity is null) return true;
                foreach (SaleUnit item in commodity.SaleUnits)
                {
                    commodity.SaleUnits.Remove(item);
                }
                context.Commodities.Remove(commodity);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            // Cach hay
            //using (var context = PharmacyDbContext.Create())
            //{
            //    var commodity = new Commodity { Id = int.Parse(recordId) };
            //    context.Commodities.Attach(commodity);
            //    context.Commodities.Remove(commodity);
            //    context.SaveChanges();
            //}
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
