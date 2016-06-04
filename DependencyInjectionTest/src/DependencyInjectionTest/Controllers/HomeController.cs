using DependencyInjectionTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGreetingService _greetingSvc;

        public HomeController(IGreetingService greetingSvc)
        {
            // Instancia de clase inyectada en el constructor se asigna a variable local.
            _greetingSvc = greetingSvc;
        }

        public IActionResult Index()
        {
            ViewData["greeting"] = _greetingSvc.Greet();
            return View();
        }
    }
}