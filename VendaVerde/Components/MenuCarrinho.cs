using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaVerde.Models;
using VendaVerde.ViewModels;

namespace VendaVerde.Components
{
    public class MenuCarrinho : ViewComponent
    {
        private readonly Carrinho _carrinho;

        public MenuCarrinho(Carrinho carrinho)
        {
            _carrinho = carrinho;
        }

        public IViewComponentResult Invoke()
        {
            var itens = _carrinho.GetShoppingCartItems();
            _carrinho.ItensCarrinho = itens;

            var carrinhoViewModel = new CarrinhoViewModel
            {
                Carrinho = _carrinho,
                TotalItensCarrinho = _carrinho.GetShoppingCartTotal()
            };

            return View(carrinhoViewModel);
        }
    }
}
