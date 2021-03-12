using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explain = "Amasya Elması";
            product1.stockQuantity = 15;

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Explain = "Diyarbakır Karpuzu";
            product2.stockQuantity = 9;

            Product[] products = new Product[] {product1, product2};

            //Type-safe = tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explain);
                Console.WriteLine("-------");
            }


            Console.WriteLine("------Metotlar------");
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut","Yeşil armut",12,20);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,20);
            sepetManager.Ekle2("Karpuz", "Yeşil karpuz", 12,9);
        }
    }
}




//Don't repeat yourself - DRY - Clean Code - Best Practice