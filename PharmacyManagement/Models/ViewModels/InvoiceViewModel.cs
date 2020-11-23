using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models.ViewModels
{
    public class InvoiceViewModel
    {
        public string Username { get; set; }
        public string InvoiceType { get; set; }
        public List<CommodityViewModel> Commodities { get; set; }
        public string Note { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
