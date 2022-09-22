using Microsoft.AspNetCore.Mvc;

namespace BoozeDotNet.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // display form for entry of new product
        public IActionResult Create()
        {
            return View();
        }
    }
}
