 using Microsoft.AspNetCore.Mvc;
using Ecart_MVC.Models;

namespace Ecart_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductService.GetAllProducts();
            return View(products);
        }
    }
}
