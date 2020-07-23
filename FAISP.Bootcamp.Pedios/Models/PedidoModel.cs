using System;
using FAISP.Bootcamp.Pedios.Models;

namespace FAISP.Bootcamp.Pedios.Models
{
    public class PedidoModel
    {
        public PedidoModel()
        {
        }

        public string NomeCliente { get; set; }

        public string TelefoneContato { get; set; }

        public string FormaPagamento { get; set; }

        public decimal Valor { get; set; }

        public string Bairro { get; set; }

        public string  Logradouro { get; set; }

        public string Numero{ get; set; }

        public string Cep { get; set; }

        public string Cidade  { get; set; }

        public string Complemento { get; set; }

        public Pizza Pizza { get; set; }
    }
}
