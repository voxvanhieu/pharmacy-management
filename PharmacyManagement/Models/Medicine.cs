﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models
{
    public partial class Medicine
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}