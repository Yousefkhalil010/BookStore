using Microsoft.AspNetCore.Mvc;
using WebProject.Models;
using System.Linq;

namespace WebProject.Controllers
{
    public class AuthorController : Controller
    {
        private BookStoreContextModel context { get; set; }

        public AuthorController(BookStoreContextModel cont)
        {
            context = cont;
        }

        public IActionResult Index()
        {
            var Authors = context.Authors.ToList();
            return View(Authors);
        }
    }
}
