using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models
{
    public partial class Invoice
    {
        [Key]
        public int Id { get; set; }

        public string Note { get; set; }

        public virtual User User { get; set; }

        public virtual InvoiceType Type { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime Created { get; set; } = DateTime.Now;

        public virtual ICollection<InvoiceCommodity> InvoiceCommodities { get; set; }
    }
}
