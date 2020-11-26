using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public class Product
    {
        //Id, Name, Description, Img, Price, Discount, Status
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        public int Discount { get; set; }
        public string Category { get; set; }
    }
}
