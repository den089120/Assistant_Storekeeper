using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assistant_Storekeeper.Models.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Warehouse { get; set; }
        public int ProductValue { get; set; }
        public string DateIn { get; set; }
    }
}
