using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__18._03_HW
{
    public class Product
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public Product(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
