using Microsoft.AspNetCore.Mvc;

namespace MVC_Practice1.Models
{
    public class Urun : Controller
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
    }
}
