using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebProject.Models;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.EntityFrameworkCore;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        private BookStoreContextModel context { get; set; }
        public HomeController(BookStoreContextModel cont)
        {
            context = cont;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("ema") == null)
            {
                return View("Login");
            }
            else
            {
                return RedirectToAction("Index","Admin");
            }
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            AdminModel a = context.Admin.Where(a => a.Email == email && a.Password == password).FirstOrDefault();
            if (a != null)
            {
                HttpContext.Session.SetString("ema", email);
                return RedirectToAction("Index","Admin");
            }
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }

        public IActionResult Library()
        {
            var Books = context.Books.Include(m => m.Author).ToList();
            return View(Books);
        }

        public IActionResult Contactus()
        {
            return View();
        }
        public IActionResult Search(string searchitem)
        {
            var books = context.Books.Include(g => g.Author).Where(m => m.Title.Contains(searchitem) || m.Author.Name.Contains(searchitem)).ToList();
            return View("Library", books);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}