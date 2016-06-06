using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EnvironmentsTest.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _environment;

        public HomeController(IHostingEnvironment environment)
        {
            _environment = environment;
        }
        public IActionResult Index()
        {
            if (_environment.IsDevelopment())
            {
                // ASPNET_ENV = Development
                ViewData["environment"] = "Desarrollo";
            }
            else if (_environment.IsStaging())
            {
                // ASPNET_ENV = Staging
                ViewData["environment"] = "Pruebas - Staging";
            }
            else if (_environment.IsProduction())
            {
                // ASPNET_ENV = Production
                ViewData["environment"] = "Produccion";
            }
            else if (_environment.IsEnvironment("MiAmbiente"))
            {
                // ASPNET_ENV = MiAmbiente
                ViewData["environment"] = "Mi ambiente";
            }
            else
            {
                // ASPNET_ENV = ?
                ViewData["environment"] = "Otro ambiente :P";
            }

            return View();
        }
    }
}
