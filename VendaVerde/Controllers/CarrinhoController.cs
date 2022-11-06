using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaVerde.Models;
using VendaVerde.Models.Interfaces;
using VendaVerde.ViewModels;

namespace VendaVerde.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly Carrinho _carrinho;

        public CarrinhoController(IProdutoRepository produtoRepository, Carrinho carrinho)
        {
            _produtoRepository = produtoRepository;
            _carrinho = carrinho;
        }

        public IActionResult Index()
        {
            var items = _carrinho.GetShoppingCartItems();
            _carrinho.ItensCarrinho = items;

            var carrinhoViewModel = new CarrinhoViewModel
            {
                Carrinho = _carrinho,
                TotalItensCarrinho = _carrinho.GetShoppingCartTotal()
            };

            return View(carrinhoViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int produtoId)
        {
            var selectedProduto = _produtoRepository.AllProdutos.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (selectedProduto != null)
            {
                _carrinho.AddToCart(selectedProduto, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int produtoId)
        {
            var selectedProduto = _produtoRepository.AllProdutos.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (selectedProduto != null)
            {
                _carrinho.RemoveFromCart(selectedProduto);
            }
            return RedirectToAction("Index");
        }
    }
}
