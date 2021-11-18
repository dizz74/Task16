using System;
using System.IO;

using System.Text.Json;
namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            string jsontext = "";
            using (StreamReader sr = new StreamReader("../../../../Products.json"))
            {
                jsontext = sr.ReadToEnd();
            }

            Product[] products = JsonSerializer.Deserialize<Product[]>(jsontext);

            Product maxProduct = products[0];
            foreach (Product p in products)
            {
                if (p.Cost > maxProduct.Cost) maxProduct = p;
            }
            if (maxProduct != null)
                Console.WriteLine("Самый дорогой товар:{0} {1:f2} руб", maxProduct.Name, maxProduct.Cost);
            Console.ReadKey();
        }

        class Product
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public double Cost { get; set; }


        }
    }
}
