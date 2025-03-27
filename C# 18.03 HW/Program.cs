namespace C__18._03_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guid id0 = Guid.NewGuid();
            string name0 = "Fox";
            string category0 = "Fox";
            Guid id;
            string name = "Fox";
            double price = 31.23;
            string category = "Machine";
            Product p = new Product(name, price, category);
            Guid id2;
            string name2 = "Tec";
            double price2 = 41.25;
            string category2 = "Cook machine";
            Product p2 = new Product(name2, price2, category2);
            Shop s = new Shop();
            s.Plus(p, p2);
            s.Show();
            s.SearchName(name0);
            s.SearchCategory(category0);
            s.FindTheMostExpensive();
            s.Delete(id0);
        }
    }
}
