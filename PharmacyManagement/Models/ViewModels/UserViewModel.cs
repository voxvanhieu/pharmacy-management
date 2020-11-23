using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        
        public string FullName { get; set; }

        public string Address { get; set; }

        public bool Gender { get; set; }
        
        public string Image { get; set; }
        
        public DateTime Birthday { get; set; }
        
        public DateTime Created { get; set; }
        
        public Role Role { get; set; }
    }
}
