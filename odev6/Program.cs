using System;

namespace odev6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.UrunAdi = "Telefon";
            product1.UrunFiyati = 1782;
            product1.UrunAdedi = 52;

            Products product2 = new Products();
            product2.UrunAdi = "Şarj Aleti";
            product2.UrunFiyati = 54;
            product2.UrunAdedi = 8;

            Products product3 = new Products();
            product3.UrunAdi = "Kulaklık";
            product3.UrunFiyati = 786;
            product3.UrunAdedi = 20;

            Products[] urunler = new Products[] { product1, product2, product3 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyati);
            }


        }
    }

    class Products
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public int UrunAdedi { get; set; }
    }
}
