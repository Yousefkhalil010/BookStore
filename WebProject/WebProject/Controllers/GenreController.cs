using Microsoft.AspNetCore.Mvc;
using WebProject.Models;
using System.Linq;

namespace WebProject.Controllers
{
    public class GenreController : Controller
    {
        private BookStoreContextModel context { get; set; }

        public GenreController(BookStoreContextModel cont)
        {
            context = cont;
        }

        public IActionResult Index()
        {
            var Genres = context.Genres.ToList();
            return View(Genres);
        }
    }
}
