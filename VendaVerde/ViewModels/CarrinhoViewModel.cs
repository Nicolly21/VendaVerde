using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaVerde.Models;

namespace VendaVerde.ViewModels
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho { get; set; }
        public decimal TotalItensCarrinho { get; set; }
    }
}
