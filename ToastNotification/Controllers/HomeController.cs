using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using ToastNotification.Models;

namespace ToastNotification.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INotyfService _notyfService;

        public HomeController(ILogger<HomeController> logger, INotyfService notyfService)
        {
            _logger = logger;
            _notyfService = notyfService;
        }




        public IActionResult Index()
        {
            //_notyfService.Custom("Notificação Customizada...", 10, "#B500FF", "fa fa-home");
            _notyfService.Success("Você salvou os dados com sucesso.", 5);
            _notyfService.Error("Exceção...");
            _notyfService.Warning("Aviso...");
            _notyfService.Information("Bem-vindo ao CoreSpider.", 5);
            return View();
        }

        [HttpPost]
        public IActionResult Index(string submit)
        {
            switch (submit)
            {
                case "Success":
                    _notyfService.Success("Você salvou os dados com sucesso.");
                    break;
                case "Info":
                    _notyfService.Information("Bem-vindo ao CoreSpider.", 5);
                    break;
                case "Error":
                    _notyfService.Error("Exceção...");
                    break;
                case "Warning":
                    _notyfService.Warning("Aviso...");
                    break;
            }
            return View();
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
