using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaVerde.Models
{
    public class ItemCarrinho
    {
        public int ItemCarrinhoId { get; set; }
        public int Quantidade { get; set; }
        public string CarrinhoId { get; set; }
        public Produto Produto { get; set; }
    }
}
