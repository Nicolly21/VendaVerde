using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaVerde.Models.Interfaces;

namespace VendaVerde.Models.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly Carrinho _carrinho;

        public PedidoRepository(AppDbContext appDbContext, Carrinho carrinho)
        {
            _appDbContext = appDbContext;
            _carrinho = carrinho;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.DataPedido = DateTime.Now;

            pedido.TotalPedido = _carrinho.GetShoppingCartTotal();

            pedido.DetalhePedidos = new List<DetalhePedido>();

            var itensCarrinho = _carrinho.ItensCarrinho;
            foreach (var item in itensCarrinho)
            {
                var detalhePedido = new DetalhePedido()
                {
                    Quantidade = item.Quantidade,
                    ProdutoId = item.Produto.ProdutoId,
                    Preco = item.Produto.Preco
                };

                pedido.DetalhePedidos.Add(detalhePedido);
            }
            _appDbContext.Pedidos.Add(pedido);

            _appDbContext.SaveChanges();
        }
    }
}
