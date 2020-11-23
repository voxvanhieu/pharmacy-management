using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models
{
    public class SaleUnit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string SaleUnitName { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public decimal SaleUnitPrice { get; set; }

        [ForeignKey("Commodity")]
        public int CommodityId { get; set; }

        public virtual Commodity Commodity { get; set; }
    }
}
