using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FAISP.Bootcamp.Pedios.Models;
using FAISP.Bootcamp.Pedios.Servicos;

namespace FAISP.Bootcamp.Pedios.Controllers
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
            try
            {

                var cardapioServico = new CardapioServico();
                var cardapio = cardapioServico.ListarCardapio();

                ViewBag.Error = "";

                return View(cardapio);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View(new List<Pizza>());
            }
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
