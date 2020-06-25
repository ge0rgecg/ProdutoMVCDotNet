using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BematechMVC.Models
{
    public class CriarPedidoViewModel
    {
        public CriarPedidoViewModel()
        {
            ListaProduto = new List<SelectListItem>();
            ListaProduto.Add(new SelectListItem() { Text = "Selecionar", Value = "-1" });
            ListaCliente = new List<SelectListItem>();
            ListaCliente.Add(new SelectListItem() { Text = "Selecionar", Value = "-1" });
            ListaPedidoItem = new List<PedidoItem>();
            PedidoItem = new List<PedidoItemViewModel>();
        }
        
        [DisplayName("Cliente")]
        public int IdCliente { get; set; }

        [DisplayName("Produto")]
        public int IdProduto { get; set; }

        public virtual Pedido Pedido { get; set; }

        public virtual ICollection<PedidoItem> ListaPedidoItem { get; set; }

        public IEnumerable<PedidoItemViewModel> PedidoItem { get; set; }

        public double ValorFinal { get; set; }

        [DisplayName("Data Entrega")]
        [Required(ErrorMessage = "A data é obrigatória")]
        public DateTime? DataEntrega { get; set; }

        public List<SelectListItem> ListaProduto { get; set; }

        public List<SelectListItem> ListaCliente { get; set; }
    }
}