using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FAISP.Bootcamp.Pedios.Models;

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
            ItemPedido item1 = new ItemPedido();
            item1.IdPedido = 1;
            item1.UrlImagem = "https://cache.dominos.com/olo/6_28_0/assets/build/market/BR/_pt/images/img/products/larges/S_PIZQU.jpg";
            item1.Titulo = "Pizza 01";
            item1.Descricao = "Frango com Catupiry";

            ItemPedido item2 = new ItemPedido();
            item1.IdPedido = 2;
            item2.UrlImagem = "https://cache.dominos.com/olo/6_28_0/assets/build/market/BR/_pt/images/img/products/larges/S_PIZQU.jpg";
            item2.Titulo = "Pizza 02";
            item2.Descricao = "Portugesa";

            ItemPedido item3 = new ItemPedido();
            item1.IdPedido = 3;
            item3.UrlImagem = "https://cache.dominos.com/olo/6_28_0/assets/build/market/BR/_pt/images/img/products/larges/S_PIZQU.jpg";
            item3.Titulo = "Pizza 03";
            item3.Descricao = "Quatro Queijos";

            var cardapio = new List<ItemPedido>();
            cardapio.Add(item1);
            cardapio.Add(item2);
            cardapio.Add(item3);

            return View(cardapio);
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
