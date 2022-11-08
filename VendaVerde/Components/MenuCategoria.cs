using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaVerde.Models.Interfaces;

namespace VendaVerde.Components
{
    public class MenuCategoria : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public MenuCategoria(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.AllCategorias.OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }
    }
}
