using System;

namespace KodlamaIoGun2
{
    class Program
    {
        static void Main(string[] args)
        {
            // CategoryId'lerin karşılıkları:
            // 1 = Oyuncaklar
            // 2 = Kitaplar
            // 3 = Hobi Eşyaları
            

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Bez Bebek";
            product1.UnitPrice = 15;
            product1.UnitInStock = 22;

            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 2;
            product2.ProductName = "Hikaye Kitabı";
            product2.UnitPrice = 30;
            product2.UnitInStock = 15;

            Product product3 = new Product();
            product3.Id = 3;
            product3.CategoryId = 3;
            product3.ProductName = "Akrilik Boya";
            product3.UnitPrice = 40;
            product3.UnitInStock = 5;

            Product[] products = new Product[] {product1, product2, product3};


            foreach (var product in products)
            {
                Console.WriteLine("Ürünün Adı: " + product.ProductName + "\n" + "Ürünün Fiyatı: " + product.UnitPrice + "\n" + "Stok adedi: " + product.UnitInStock);
                Console.WriteLine("\n---------------------------------------------------\n");
            }
        }
    }
}
