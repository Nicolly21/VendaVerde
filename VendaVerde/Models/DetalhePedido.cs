namespace VendaVerde.Models
{
    public class DetalhePedido
    {
        public int DetalhePedidoId { get; set; }
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
    }
}