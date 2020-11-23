using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models
{
    public partial class CommodityType
    {
        public CommodityType()
        {
            Commodities = new HashSet<Commodity>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(255)]
        public string Name { get; set; }

        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
