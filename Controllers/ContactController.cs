using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
