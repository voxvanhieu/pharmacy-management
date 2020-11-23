using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(64)]
        public string UserName { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(300)]
        public string FullName { get; set; }

        public string Address { get; set; }

        public bool Gender { get; set; }

        public string Image { get; set; }

        [Column(TypeName = "Date")]
        //[DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime Created { get; set; } = DateTime.Now;

        [Required]
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
