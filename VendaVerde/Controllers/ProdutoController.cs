using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VendaVerde.Models;
using VendaVerde.Models.Interfaces;
using VendaVerde.ViewModels;

namespace VendaVerde.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public ProdutoController(ILogger<ProdutoController> logger, IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {
            _logger = logger;
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Produtos(string categoria)
        {
            IEnumerable<Produto> produtos;
            string categoriaAtual;

            if (string.IsNullOrEmpty(categoria))
            {
                produtos = _produtoRepository.AllProdutos.OrderBy(p => p.ProdutoId);
                categoriaAtual = "Todos os produtos";
            }
            else
            {
                produtos = _produtoRepository.AllProdutos.Where(p => p.Categoria.CategoriaNome == categoria)
                    .OrderBy(p => p.ProdutoId);
                categoriaAtual = _categoriaRepository.AllCategorias.FirstOrDefault(c => c.CategoriaNome == categoria)?.CategoriaNome;
            }

            return View(new ProdutoListViewModel
            {
                Produtos = produtos,
                CategoriaAtual = categoriaAtual
            });
        }

        public IActionResult Detalhes(int id)
        {
            var produto = _produtoRepository.ObterProduto(id);

            if (produto == null)
                return NotFound();

            return View(produto);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
