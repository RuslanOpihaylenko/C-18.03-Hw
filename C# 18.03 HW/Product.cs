using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__18._03_HW
{
    internal class Product
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public List<Product> Products { get; set; }
        public Product(Guid id, string name, double price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }
        public void Show()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine(Products[i]);
            }
        }
        public void SearchName(string name)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (name == Products[i].Name)
                {
                    Console.WriteLine(Products[i]);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public void SearchCategory(string category)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (category == Products[i].Category)
                {
                    Console.WriteLine(Products[i]);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public void FindTheMostExpensive()
        {
            double max = 0;
            for (int i = 0; i < Products.Count; i++) 
            {
                if (max < Products[i].Price)
                {
                    max = Products[i].Price;
                }
            }
            Console.WriteLine(max);
        }
        public void Delete(Guid id)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (id != Products[i].Id)
                {
                    Console.WriteLine(Products[i]);
                }
            }
        }
    }
}
