using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BematechMVC.Models
{
    public class ListaBuscaPedidoViewModel
    {
        public ListaBuscaPedidoViewModel(string numero, string nome, decimal valor)
        {
            this.NumeroPedido = int.Parse(numero);
            this.NomeCliente = nome;
            this.ValorTotal = valor;
        }
        public int NumeroPedido { get; set; }
        public string NomeCliente { get; set; }
        public decimal ValorTotal { get; set; }
    }
}