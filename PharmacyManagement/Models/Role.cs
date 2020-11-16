using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PharmacyManagement.Models
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}