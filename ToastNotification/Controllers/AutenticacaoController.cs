using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using ToastNotification.Models;

namespace ToastNotification.Controllers
{
    public class AutenticacaoController : Controller
    {
        private readonly INotyfService _notyfService;

        public AutenticacaoController(INotyfService notyfService)
        {
            _notyfService = notyfService;
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Usuario usuario)
        {
            _notyfService.Success("Dados cadastrados com sucesso.", 5);
            return View();
        }
    }
}
