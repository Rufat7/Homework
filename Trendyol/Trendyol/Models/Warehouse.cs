﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendyol.Models
{
    class Warehouse
    {
        [Key]
        public int Id { get; set; }
        [Required,]
        public int ProductId { get; set; }
        [Required]
        public int count { get; set; }
    }
}
