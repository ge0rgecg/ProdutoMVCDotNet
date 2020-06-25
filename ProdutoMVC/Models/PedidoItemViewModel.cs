using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BematechMVC.Models
{
    public class PedidoItemViewModel
    {
        public string Quantidade { get; set; }
        public virtual ProdutoViewModel Produto { get; set; }
        public string ValorTotal { get; set; }
    }
}