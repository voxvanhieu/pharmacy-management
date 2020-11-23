using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models.ViewModels
{
    public class CommodityViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public string SaleUnit { get; set; }
        public decimal SalePrice { get; set; }
        public int Quantity { get; set; }
    }
}
