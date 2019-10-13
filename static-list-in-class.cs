using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace z_AddProductsToList
{
    public class ProductsDB
    {
        public static Dictionary<int, ProductCatalog> Products = new Dictionary<int, ProductCatalog>();
        
        public void Add(int id, ProductCatalog productCatalog)
        {
            ProductsDB.Products.Add(id, productCatalog );
        }
        public void Remove(int id)
        {
            ProductsDB.Products.Remove(id);
        }
        public void ChangePrice(int id, int newPrice)
        {
            ProductsDB.Products[id].PriceCurrent = newPrice;
        }
        public void ListByAfterGivenDate(DateTime date)
        {
            ProductsDB productsDB = new ProductsDB();

            foreach (var item in Products)
            {
                if(item.Value.DateAdded > date)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine($" - {item.Value.Name} - ");
                    Console.WriteLine($"price : {item.Value.PriceCurrent}, added by {item.Value.User}");
                    Console.WriteLine($"at : {item.Value.DateAdded}");
                }
            }
        }
    }
    public delegate DateTime ListDate(DateTime date);
    public class ProductCatalog
    {
        public string Name { get; set; }
        public decimal PriceCurrent { get; set; }
        public string User { get; set; }
        public DateTime DateAdded { get; set; }
    }
    public class Test
    {
        public delegate void ListItems(DateTime date);
        static void Main(string[] args)
        {
            Test test = new Test();
            ProductsDB prodDB = new ProductsDB();
            test.InitialAdd();

            DateTime currentDate = DateTime.Now;
            ListItems discount = new ListItems(prodDB.ListByAfterGivenDate);
            discount.Invoke(currentDate);

           
        }

        public void InitialAdd()
        {
            ProductsDB prodDB = new ProductsDB();
            //prodDB.Products = new Dictionary<int, ProductCatalog>();
            prodDB.Add(1, new ProductCatalog { Name = "Test", User = "Admin",
                PriceCurrent = 9.99m, DateAdded = new DateTime(2019, 10, 13)});
            prodDB.Add(2, new ProductCatalog { Name = "Obqva1", User = "petar",
                PriceCurrent = 100m, DateAdded = new DateTime(2019, 10, 15)});
            prodDB.Add(3, new ProductCatalog
            {
                Name = "Himikal",
                User = "User3",
                PriceCurrent = 2.00m,
                DateAdded = new DateTime(2019, 10, 16)
            });
            prodDB.Add(4, new ProductCatalog
            {
                Name = "Laptop",
                User = "fore",
                PriceCurrent = 1000m,
                DateAdded = new DateTime(2019, 01, 13)
            });
            prodDB.Add(5, new ProductCatalog
            {
                Name = "Blahblahblah",
                User = "ico",
                PriceCurrent = 9.99m,
                DateAdded = new DateTime(2019, 10, 13)
            });
        }
       
    }
}
