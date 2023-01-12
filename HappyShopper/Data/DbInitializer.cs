//using HappyShopper.Entities;
//using System.Collections.Generic;
//using System.Linq;

//namespace HappyShopper.Data
//{
//    public static class DbInitializer
//    {
//        public static void Initialize(StoreContext storeContext)
//        {
//            if (storeContext.Products.Any()) return;

//            var products = new List<Product>
//            {
//                new Product
//                {
//                    Name = "Eskimo boots",
//                    Description = "Cool and soft",
//                    Price = 485,
//                    PictureUrl = "images/products/boots-reddis.png",
//                    Type = "Boots",
//                    Brand = "Reddis",
//                    QuantityInStock = 100

//                },
//                new Product
//                {
//                    Name = "Nike Hoodie",
//                    Description = "Cool fashion",
//                    Price = 485,
//                    PictureUrl = "images/products/hoodie.png",
//                    Type = "Hoodie",
//                    Brand = "Nike",
//                    QuantityInStock = 332

//                },
//                new Product
//                {
//                    Name = "Chinese Chop Sticks",
//                    Description = "Very effective",
//                    Price = 113,
//                    PictureUrl = "images/products/chopsticks.png",
//                    Type = "Cutlery",
//                    Brand = "Chinatown",
//                    QuantityInStock = 405

//                },

//            };

//            storeContext.Products.AddRange(products);
//            storeContext.SaveChanges();
//        }
//    }
//}
