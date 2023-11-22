using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using teploobmen.Data;
using teploobmen.Models;
using TeploobmenLibrary;
using TeploobmenLibrary.Models;

namespace teploobmen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyApplicationContext _context;

        public HomeController(ILogger<HomeController> logger, MyApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var inputDatas = _context.InputDatas.ToList();
            return View(inputDatas);
        }

        [HttpPost]
        public IActionResult TestPage(TestPageModel model)
        {
            if (model.InputData == null) { return View(); }
            var transferData = new TeploobmenInputData
            {
                RasH = model.InputData.RasH,
                RasTm = model.InputData.RasTm,
                RasTg = model.InputData.RasTg,
                RasV = model.InputData.RasV,
                RasTemG = model.InputData.RasTemG,
                RasRas = model.InputData.RasRas,
                RasTemM = model.InputData.RasTemM,
                RasTepl = model.InputData.RasTepl,
                RasD = model.InputData.RasD,
            };
            var output = TeploobmenLib.Calculate(transferData);
            model.OutputModel = output;
            _context.InputDatas.Add(model.InputData);
            _context.SaveChanges();
            return View(model);
        }

        [HttpGet]
        public IActionResult TestPage([FromQuery] int variant)
        {
            if (variant == 0) return View();
            var vardata = _context.InputDatas.FirstOrDefault(x => x.ID == variant);
            var data = new TestPageModel
            {
                InputData = vardata,
            };
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