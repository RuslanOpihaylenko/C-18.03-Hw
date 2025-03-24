namespace C__18._03_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guid id0 = Guid.NewGuid();
            string name0 = "Fox";
            string category0 = "Fox";
            Guid id = Guid.NewGuid();
            string name = "Fox";
            double price = 31.23;
            string category = "Machine";
            Product p = new Product(id, name, price, category);
            Guid id2 = Guid.NewGuid();
            string name2 = "Tec";
            double price2 = 41.25;
            string category2 = "Cook machine";
            Product p2 = new Product(id2, name2, price2, category2);
            List<Product> products = new List<Product>();
            products.Add(p);
            products.Add(p2);
            p.Show();
            p.SearchName(name0);
            p.SearchCategory(category0);
            p.FindTheMostExpensive();
            p.Delete(id0);
            p2.Show();
            p2.SearchName(name0);
            p2.SearchCategory(category0);
            p2.FindTheMostExpensive();
            p2.Delete(id0);
        }
    }
}
