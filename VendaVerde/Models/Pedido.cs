using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VendaVerde.Models
{
    public class Pedido
    {
        [BindNever]
        public int PedidoId { get; set; }
        public List<DetalhePedido> DetalhePedidos { get; set; }

        [Required(ErrorMessage = "Por favor informe seu nome")]
        [Display(Name = "Primeiro nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor informe seu sobrenome")]
        [Display(Name = "Sobrenome")]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Por favor informe seu endereço")]
        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Por favor informe seu CEP")]
        [Display(Name = "CEP")]
        [StringLength(8, MinimumLength = 4)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Por favor informe sua cidade")]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Por favor informe seu estado")]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Por favor informe seu país")]
        [StringLength(50)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Por favor informe seu telefone")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Por favor informe um e-mail válido")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal TotalPedido { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime DataPedido { get; set; }

    }
}
