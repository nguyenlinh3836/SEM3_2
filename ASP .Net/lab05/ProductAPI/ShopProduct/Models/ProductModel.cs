using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopProduct.Models
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public int qty { get; set; }
    }
}