using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assistant_Storekeeper.Models
{
    public class MoveProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdProduct { get; set; }
        [Required]
        public string NameProduct { get; set; }
        [Required]
        public string WarehouseOut { get; set; }
        [Required]
        public string WarehouseIn { get; set; }
        [Required]
        public int ChangeValue { get; set; }
        [Required]
        public string DateIn { get; set; }
    }
}
