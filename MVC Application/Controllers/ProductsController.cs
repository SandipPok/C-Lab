using Microsoft.AspNetCore.Mvc;

namespace MVC_Application.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Category()
        { 
            return View();
        }
    }
}
  