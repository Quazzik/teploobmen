using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using teploobmen.Models;
using TeploobmenLibrary;
using TeploobmenLibrary.Models;

namespace teploobmen.Controllers
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

        [HttpPost]
        public IActionResult TestPage(TeploobmenInputData inputData)
        {
            var output = TeploobmenLib.Calculate(inputData);

            return View(output);
        }

        [HttpGet]
        public IActionResult TestPage()
        {
            var data = new TeploobmenOutputModel();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}