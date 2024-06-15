using Microsoft.AspNetCore.Mvc;
using WebProject.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            if (HttpContext.Session.GetString("ema") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                var Genres = context.Genres.ToList();
                return View(Genres);
            }
        }
    }
}
