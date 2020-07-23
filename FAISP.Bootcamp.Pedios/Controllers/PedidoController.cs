using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FAISP.Bootcamp.Pedios
{
    public class PedidoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int idItemCardapio)
        {
            return View();
        }
    }
}
