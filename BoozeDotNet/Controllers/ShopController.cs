using BoozeDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoozeDotNet.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category(string CategoryName)
        {
            if (CategoryName == null)
            {
                return RedirectToAction("Index");
            }
            
            // pass input param val to ViewData for display in the view
            ViewData["CategoryName"] = CategoryName;

            // use Product model to mock a list of products for display
            var products = new List<Product>();

            for (var i = 1; i < 11; i++)
            {
                products.Add(new Product { ProductId = i, Name = "Product " + i.ToString() });
            }

            return View(products);
        }
    }
}
