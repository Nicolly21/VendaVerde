using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaVerde.Models
{
    public class Carrinho
    {
        private readonly AppDbContext _appDbContext;
        public string CarrinhoId { get; set; }

        public List<ItemCarrinho> ItensCarrinho { get; set; }

        private Carrinho(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static Carrinho GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new Carrinho(context) { CarrinhoId = cartId };
        }

        public void AddToCart(Produto produto, int quantidade)
        {
            //Verifica no BD se já existe um carrinho com o ID da sessão
            var ItemCarrinho =
                    _appDbContext.ItensCarrinho.SingleOrDefault(
                        s => s.Produto.ProdutoId == produto.ProdutoId && s.CarrinhoId == CarrinhoId);

            //Se não houver monta o item no carrinho e adiciona
            if (ItemCarrinho == null)
            {
                ItemCarrinho = new ItemCarrinho
                {
                    CarrinhoId = CarrinhoId,
                    Produto = produto,
                    Quantidade = 1
                };

                _appDbContext.ItensCarrinho.Add(ItemCarrinho);
            }
            else
            {
                ItemCarrinho.Quantidade++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Produto produto)
        {
            var ItemCarrinho =
                    _appDbContext.ItensCarrinho.SingleOrDefault(
                        s => s.Produto.ProdutoId == produto.ProdutoId && s.CarrinhoId == CarrinhoId);

            var localAmount = 0;

            if (ItemCarrinho != null)
            {
                if (ItemCarrinho.Quantidade > 1)
                {
                    ItemCarrinho.Quantidade--;
                    localAmount = ItemCarrinho.Quantidade;
                }
                else
                {
                    _appDbContext.ItensCarrinho.Remove(ItemCarrinho);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<ItemCarrinho> GetShoppingCartItems()
        {
            //Retorna itens da tabela ItensCarrinho join com Tabela Produto
            return ItensCarrinho ??
                   (ItensCarrinho =
                       _appDbContext.ItensCarrinho.Where(c => c.CarrinhoId == CarrinhoId)
                           .Include(s => s.Produto)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext
                .ItensCarrinho
                .Where(cart => cart.CarrinhoId == CarrinhoId);

            _appDbContext.ItensCarrinho.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ItensCarrinho.Where(c => c.CarrinhoId == CarrinhoId)
                .Select(c => c.Produto.Preco * c.Quantidade).Sum();
            return total;
        }
    }
}
