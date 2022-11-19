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

        [HttpPost]
        public IActionResult Checkout(Pedido pedido)
        {
            var itens = _carrinho.GetShoppingCartItems();
            _carrinho.ItensCarrinho = itens;

            if (_carrinho.ItensCarrinho.Count == 0){
                ModelState.AddModelError("", "Seu carrinho está vazio, fique a vontade para conhecer nossos produtos em catálogo");
            }

            if (ModelState.IsValid)
            {
                _pedidoRepository.CriarPedido(pedido);
                _carrinho.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(pedido);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Obrigado pela sua compra, seus produtos em breve chegará em sua casa!";

            return View();
        }
    }
}
