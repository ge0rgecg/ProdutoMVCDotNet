using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BematechMVC.Models
{
    public class ProdutoViewModel
    {
        public string Descricao { get; set; }
        public int IdProduto { get; set; }
        public decimal Valor { get; set; }
    }
}