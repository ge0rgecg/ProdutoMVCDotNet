using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;

namespace BematechMVC.Models
{
    public class BuscaPedidoViewModel
    {
        public BuscaPedidoViewModel()
        {
            ListaCliente = new List<SelectListItem>();
            ListaPedidos = new List<Pedido>();
        }

        [DisplayName("Cliente")]
        public int? IdCliente { get; set; }

        public IEnumerable<Pedido> ListaPedidos { get; set; }

        [DisplayName("Número")]
        public int? IdPedido { get; set; }

        public DateTime? DataInicial { get; set; }

        public DateTime? DataFinal { get; set; }

        public List<SelectListItem> ListaCliente { get; set; }
    }
}