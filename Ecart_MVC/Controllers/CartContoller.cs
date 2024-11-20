//  using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using Ecart_MVC.Models; 

// namespace Ecart_MVC.Controllers
// {
//     public class MyController : Controller
//     {
//         private readonly List<Product> _products;

//         public MyController()
//         {
//             _products = new List<Product>
//             {
//                 new Product { ProdId = "1", ProdName = "Apple", ProdDesc = "Fresh Red Apples", ProdPrice = 25, ProdType = "Fruit", catId = 101 },
//                 new Product { ProdId = "2", ProdName = "Banana", ProdDesc = "Ripe Yellow Bananas", ProdPrice = 15, ProdType = "Fruit", catId = 101 },
//                 new Product { ProdId = "3", ProdName = "Carrot", ProdDesc = "Organic Carrots", ProdPrice = 20, ProdType = "Vegetable", catId = 102 },
//                 new Product { ProdId = "4", ProdName = "Broccoli", ProdDesc = "Fresh Broccoli Florets", ProdPrice = 30, ProdType = "Vegetable", catId = 102 },
//                 new Product { ProdId = "5", ProdName = "Milk", ProdDesc = "Whole Milk", ProdPrice = 10, ProdType = "Dairy", catId = 105 },
//                 new Product { ProdId = "6", ProdName = "Cheese", ProdDesc = "Cheddar Cheese", ProdPrice = 50, ProdType = "Dairy", catId = 105 },
//                 new Product { ProdId = "7", ProdName = "Bread", ProdDesc = "Whole Grain Bread", ProdPrice = 25, ProdType = "Bakery", catId = 106 },
//                 new Product { ProdId = "8", ProdName = "Oatmeal", ProdDesc = "Healthy Instant Oatmeal", ProdPrice = 35, ProdType = "Grains", catId = 108 },
//                 new Product { ProdId = "9", ProdName = "Potato", ProdDesc = "Fresh Potatoes", ProdPrice = 15, ProdType = "Vegetable", catId = 102 },
//                 new Product { ProdId = "10", ProdName = "Spinach", ProdDesc = "Fresh Spinach Leaves", ProdPrice = 20, ProdType = "Vegetable", catId = 102 }
//             };
//         }

//         public IActionResult Index()
//         {
//             return View();
//         }

//         public IActionResult Product()
//         {
//             return View(_products);
//         }
//     }
// }