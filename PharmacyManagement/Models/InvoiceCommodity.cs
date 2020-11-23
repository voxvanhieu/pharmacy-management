using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models
{
    public class InvoiceCommodity
    {
        [Key]
        public int Id { get; set; }

        public int CommodityQuantity { get; set; } = 0;
        public string SaleUnit { get; set; }
        public decimal SalePrice { get; set; }

        [Required]
        [ForeignKey("Invoice")]
        public int InvoiceID { get; set; }


        [Required]
        [ForeignKey("Commodity")]
        public int CommodityId { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Commodity Commodity { get; set; }
    }
}
