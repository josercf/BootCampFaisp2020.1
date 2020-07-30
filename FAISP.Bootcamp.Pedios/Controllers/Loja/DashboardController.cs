using FAISP.Bootcamp.Pedios.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace FAISP.Bootcamp.Pedios.Controllers.Loja
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var pedidoServico = new PedidoServico();
            var pedidos = pedidoServico.ListarPedidos();

            return View(pedidos);
        }
    }
}
