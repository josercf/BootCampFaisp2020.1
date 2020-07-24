using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAISP.Bootcamp.Pedios.Models;
using FAISP.Bootcamp.Pedios.Servicos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FAISP.Bootcamp.Pedios.Controllers
{
    public class PedidoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int idItemCardapio)
        {
            var cardapioServico = new CardapioServico();
            var pizza = cardapioServico.ObterPizza(idItemCardapio);

            var model = new PedidoModel();
            model.Valor = pizza.Valor;
            model.Pizza = pizza;

            return View(model);
        }



        [HttpPost]
        public IActionResult FazerPedido(PedidoModel model)
        {


            return View("Index");
        }
    }
}
