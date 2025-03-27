using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__18._03_HW
{
    public class Shop
    {
        List<Product> products = new List<Product>();
        public void Plus(Product fir, Product sec)
        {
            products.Add(fir);
            products.Add(sec);
        }
        public void Show()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].Name);
                Console.WriteLine(products[i].Price);
                Console.WriteLine(products[i].Category);
            }
        }
        public void SearchName(string name)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (name == products[i].Name)
                {
                    Console.WriteLine(products[i]);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public void SearchCategory(string category)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (category == products[i].Category)
                {
                    Console.WriteLine(products[i]);
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
            for (int i = 0; i < products.Count; i++)
            {
                if (max < products[i].Price)
                {
                    max = products[i].Price;
                }
            }
            Console.WriteLine(max);
        }
        public void Delete(Guid id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (id == products[i].Id)
                {
                    products.Remove(products[i]);
                }
            }
        }
    }
}
