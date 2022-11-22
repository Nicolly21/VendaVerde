using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaVerde.Models.Interfaces;

namespace VendaVerde.Models.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProdutoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Produto> AllProdutos
        {
            get
            {
                return _appDbContext.Produtos.Include(c => c.Categoria);
            }
        }
        
        public Produto ObterProduto(int produtoID)
        {
            return _appDbContext.Produtos.FirstOrDefault(p => p.ProdutoId == produtoID);
        }
    }
}
