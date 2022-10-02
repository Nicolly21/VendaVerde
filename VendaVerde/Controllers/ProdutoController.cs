using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
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

        public ViewResult Index()
        {
            ProdutoListViewModel produtoListViewModel = new ProdutoListViewModel();
            produtoListViewModel.Produtos = _produtoRepository.AllProdutos;
            produtoListViewModel.CategoriaAtual = "Verduras";

            return View(produtoListViewModel);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

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
