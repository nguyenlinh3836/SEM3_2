using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public class Cart
    {
        public List<Cartline> Lines { get; set; } = new List<Cartline>();
        public void AddItem(Product product, int quantity)
        {
            Cartline line = Lines
                .Where(p => p.Product.Id == product.Id)
                .FirstOrDefault();
            if(line == null)
            {
                Lines.Add(new Cartline
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product)
            => Lines.RemoveAll(l => l.Product.Id == product.Id);

        public decimal ComputeTotalValue()
            => Lines.Sum(e => e.Product.Price * e.Quantity);

        public void Clear()
            => Lines.Clear();
    }

    public class Cartline
    {
        public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
