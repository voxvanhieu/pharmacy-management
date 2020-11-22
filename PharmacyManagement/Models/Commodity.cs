using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models
{
    public class Commodity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Provider { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("CommodityType")]
        public string CommodityTypeId { get; set; }

        public virtual CommodityType CommodityType { get; set; }
    }
}
