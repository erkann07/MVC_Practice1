using Microsoft.AspNetCore.Mvc;
using MVC_Practice1.Models;
namespace MVC_Practice1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var urun = new List<Urun>
            {
                new Urun { Id = 1,Name = "Phone", Price = 18000 },
                new Urun { Id = 2, Name = "Laptop", Price = 25000 },
                new Urun { Id = 3, Name = "Tablet", Price = 15000 },

            };
            return View(urun);
        }
    }
}
