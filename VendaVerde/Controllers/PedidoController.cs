using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaVerde.Models;
using VendaVerde.Models.Interfaces;

namespace VendaVerde.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly Carrinho _carrinho;

        public PedidoController(IPedidoRepository pedidoRepository, Carrinho carrinho)
        {
            _pedidoRepository = pedidoRepository;
            _carrinho = carrinho;
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
