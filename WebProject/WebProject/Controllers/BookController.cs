using Microsoft.AspNetCore.Mvc;
using WebProject.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebProject.Controllers
{
    public class BookController : Controller
    {
        private BookStoreContextModel context { get; set; }

        public BookController(BookStoreContextModel cont)
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
                var Books = context.Books.Include(b => b.Author).Include(G => G.Genre).ToList();
                return View(Books);
            }
        }
    }
}