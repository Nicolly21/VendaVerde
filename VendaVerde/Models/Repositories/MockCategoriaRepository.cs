using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaVerde.Models.Interfaces;

namespace VendaVerde.Models.Repositories
{
    public class MockCategoriaRepository : ICategoriaRepository
    {
        public IEnumerable<Categoria> AllCategorias =>
            new List<Categoria>
            {
                new Categoria{CategoriaID = 1, CategoriaNome = "Frutas", Descricao = "Teste Frutas Categoria"},
                new Categoria{CategoriaID = 2, CategoriaNome = "Verduras", Descricao = "Teste Verduras Categoria"},
                new Categoria{CategoriaID = 3, CategoriaNome = "Grãos", Descricao = "Teste Grãos Categoria"}
            };
    }
}
