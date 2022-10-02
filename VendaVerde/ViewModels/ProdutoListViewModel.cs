using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaVerde.Models;

namespace VendaVerde.ViewModels
{
    public class ProdutoListViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
