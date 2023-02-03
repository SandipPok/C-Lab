using CFA_EF_Core.Models;
using CFA_EF_Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CFA_EF_Core.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepo productRepo;
        public ProductController(IProductRepo repo)
        {
            productRepo = repo;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            productRepo.AddProduct(product);
            return Content("Product has been inserted successfully");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
