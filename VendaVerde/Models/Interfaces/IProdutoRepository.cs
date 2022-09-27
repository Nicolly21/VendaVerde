using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaVerde.Models.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> AllProdutos { get; }
        IEnumerable<Produto> ProdutosDaSemana { get; }
        Produto ObterProduto(int produtoID);
    }
}
