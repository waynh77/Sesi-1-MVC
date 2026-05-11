using Microsoft.AspNetCore.Mvc;
using Sesi_1.Models;
using System.Diagnostics;

namespace Sesi_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customer()
        {
            var customer = new List<Customer>
        {
            new Customer { Id = 1, Name = "Alpha",Address="Jl A" },
            new Customer { Id = 2, Name = "Beta",Address="Jl B" },
            new Customer { Id = 3, Name = "Charlie",Address="Jl C" },
            new Customer { Id = 4, Name = "Delta",Address="Jl D" },
        };
            return View(customer);
        }

        public IActionResult Product()
        {
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop",Qty=10 },
            new Product { Id = 2, Name = "Mouse",Qty=5 },
            new Product { Id = 3, Name = "Monitor",Qty=7 },
            new Product { Id = 4, Name = "Keyboard",Qty=6 },
        };
            return View(products);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
