using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebProject.Models;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.EntityFrameworkCore;

namespace WebProject.Controllers
{
    public class AdminController : Controller
    {
        private BookStoreContextModel context { get; set; }
        public AdminController(BookStoreContextModel cont)
        {
            context = cont;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            if (HttpContext.Session.GetString("ema") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                ViewBag.Name = context.Genres.ToList();
                return View();
            }
        }
        [HttpPost]
        public IActionResult Add(BookModel bk)
        {
            if (HttpContext.Session.GetString("ema") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                context.Books.Add(bk);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        public IActionResult Delete(int ID)
        {
            BookModel g = context.Books.Where(g => g.ID == ID).FirstOrDefault();
            if (g != null)
            {
                context.Remove(g);
                context.SaveChanges();
            }
            return RedirectToAction("Index");  
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Home");
        }
        public IActionResult Detail()
        {
            if (HttpContext.Session.GetString("ema") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string AdminEmail = HttpContext.Session.GetString("ema");
                AdminModel m = context.Admin.Where( m => m.Email == AdminEmail).FirstOrDefault();
                return View(m);
            }
        }
        public IActionResult AddAuthor(AuthorModel ak)
        {
            if (HttpContext.Session.GetString("ema") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                if (!string.IsNullOrEmpty(ak.Name))
                {
                    context.Authors.Add(ak);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(ak);
        }
        public IActionResult AddAdmin(AdminModel ck)
        {
            if (HttpContext.Session.GetString("ema") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                if (!string.IsNullOrEmpty(ck.Email)) 
                {
                    context.Admin.Add(ck);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(ck);
        }
    }
}
