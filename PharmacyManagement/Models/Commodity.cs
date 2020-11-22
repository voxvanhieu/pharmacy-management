using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models
{
    public class Commodity // caccc
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Provider { get; set; }

        [Required]
        public int TotalQuantity { get; set; } = 0;

        [Required]
        [StringLength(255)]
        public string BaseUnit { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public decimal BaseUnitPrice { get; set; }

        [Required]
        public string ReferenceLink { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime Created { get; set; } = DateTime.Now;

        public virtual CommodityType Type { get; set; }
    }
}
