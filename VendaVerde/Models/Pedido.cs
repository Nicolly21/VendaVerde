using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaVerde.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public List<DetalhePedido> DetalhePedidos { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string TotalPedido { get; set; }
        public DateTime DataPedido { get; set; }

    }
}
