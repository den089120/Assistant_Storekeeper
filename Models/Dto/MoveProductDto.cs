using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assistant_Storekeeper.Models.Dto
{
    public class MoveProductDto
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public string WarehouseOut { get; set; }
        public string WarehouseIn { get; set; }
        public int ChangeValue { get; set; }
        public string DateIn { get; set; }
    }
}
