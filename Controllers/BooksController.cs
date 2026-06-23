using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using MVCApp.services;

namespace MVCApp.Controllers
{
    public class BooksController : Controller
    {
          private static List<Books> _books = new List<Books>
        {
            new Books("CleanCode", "Robert C.Martin",50.0),
            new Books("The Pragmatic Program","Andrew Hunt",36.50)

        };
        // GET: BookController
        public IActionResult Index()
        {
            Logger.Instance.log("Books index page loaded");
            return View(_books);
        }
      
        public IActionResult Discount(int id, double percentage)
        {
            if (id < 0 || id >= _books.Count)
                return NotFound();
            _books[id].ApplyDiscount(percentage);
            return RedirectToAction("index");
        }

    }

}
