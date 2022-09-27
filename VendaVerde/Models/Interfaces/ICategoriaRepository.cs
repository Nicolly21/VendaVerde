using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaVerde.Models.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> AllCategorias { get; }
    }
}
