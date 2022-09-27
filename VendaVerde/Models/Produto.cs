using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaVerde.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string MaisInfo { get; set; }
        public string AlergiaInfo { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public bool IsProdutoSemana { get; set; }
        public bool InEstoque { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}
