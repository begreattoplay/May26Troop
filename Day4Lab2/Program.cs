using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Lab2
{
    class Program
    {
        public static List<Product> CreateProducts(int count)
        {
            List<Product> products = new List<Product>();
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                products.Add(new Product
                {
                    Id = rnd.Next(100),
                    Name = "Product " + i
                });
            }

            return products;
        }

        public static Product FindDuplicateProduct(List<Product> products)
        {
            foreach (Product product1 in products)
            {
                foreach (Product product2 in products)
                {
                    if (product1 != product2 && product1.Id == product2.Id)
                    {
                        return product1;
                    }
                }
            }

            return null;
        }

        public static void SortProducts(List<Product> products)
        {
            products.Sort(new ProductComparer());
        }

        static void Main(string[] args)
        {
            List<Product> products = CreateProducts(1000);
            Product dup = FindDuplicateProduct(products);
            
            while(dup != null)
            {
                products.Remove(dup);
                dup = FindDuplicateProduct(products);
            }

            SortProducts(products);
            foreach(Product product in products)
            {
                Console.WriteLine(product.Id + " is unique.");
            }

            Console.ReadLine();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductComparer: IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Id - y.Id;
        }
    }
}
