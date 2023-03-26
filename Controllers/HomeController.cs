using FirstApp.DTO;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstApp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Books()
        {
            var book = new List<Book>();
            book.Add(new Book
            {
                Author = "Ismail Kadare",
                PageNumber = 100,
                Name = "Kronike ne gur",
                DateCreated = DateTime.Now
            });

            book.Add(new Book
            {
                Author = "Ismail Kadare2",
                PageNumber = 2000,
                Name = "Kronike ne gur2",
                DateCreated = DateTime.Now
            });
            var bookDto = new List<BookDTO>();

            bookDto.Add(new BookDTO
            {
                Author = "Ismail Kadare2",
                Name = "Kronike ne gur2"
            });
            //Edit comment just for push
            ViewBag.Books = book;
            //ViewData["Id"] = 2;
            //TempData["Test"] = "Test";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}