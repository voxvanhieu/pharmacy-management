using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models
{
    public class InvoiceType
    {
        public InvoiceType()
        {
            Invoices = new HashSet<Invoice>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
