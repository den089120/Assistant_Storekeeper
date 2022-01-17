using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assistant_Storekeeper.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Warehouse { get; set; }
        [Required]
        public int ProductValue { get; set; }
        [Required]
        public string DateIn { get; set; }
    }
}

             