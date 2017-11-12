using Microsoft.AspNetCore.Mvc;


namespace Hearth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}