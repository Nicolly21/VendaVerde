using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaVerde.Models.Interfaces;

namespace VendaVerde.Models.Repositories
{
    public class MockProdutoRepository : IProdutoRepository
    {
        private readonly ICategoriaRepository _categoryRepository = new MockCategoriaRepository();

        public IEnumerable<Produto> AllProdutos =>
            new List<Produto>
            {
                new Produto{ ProdutoId = 1, Nome = "Tomate", Preco = 5.50M, Descricao = "Tomate vermelho e suculento", MaisInfo = "Tomate do tipo cereja", Categoria = _categoryRepository.AllCategorias.ToList()[0], ImagemUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InEstoque=true, IsProdutoSemana=false, ThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg" },
                new Produto{ ProdutoId = 2, Nome = "Alface", Preco = 2.20M, Descricao = "Alface fresca e verdinha", MaisInfo = "Alface crespo", Categoria = _categoryRepository.AllCategorias.ToList()[1], ImagemUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", InEstoque=true, IsProdutoSemana=false, ThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg" },
                new Produto{ ProdutoId = 3, Nome = "Cenoura", Preco = 3.70M, Descricao = "Cenoura laranjinha", MaisInfo = "Cenoura madura", Categoria = _categoryRepository.AllCategorias.ToList()[1], ImagemUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", InEstoque=true, IsProdutoSemana=false, ThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg" },
                new Produto{ ProdutoId = 4, Nome = "Maçã", Preco = 1.10M, Descricao = "Maçã docinho", MaisInfo = "Maça importado", Categoria = _categoryRepository.AllCategorias.ToList()[0], ImagemUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InEstoque=true, IsProdutoSemana=false, ThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" }
            };

        public IEnumerable<Produto> ProdutosDaSemana => throw new NotImplementedException();

        public Produto ObterProduto(int produtoID)
        {
            return AllProdutos.FirstOrDefault(p => p.ProdutoId == produtoID);
        }
    }
}
