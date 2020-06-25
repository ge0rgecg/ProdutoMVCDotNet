using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Pedido
    {
        public virtual Cliente Cliente { get; set; }
        public int? Cliente_Id { get; set; }
        public virtual ICollection<PedidoItem> ListaProduto { get; set; }
        public decimal ValorTotal { get; set; }
        //é o numero.
        public int Id_Pedido { get; set; }
        public DateTime DataEntrega { get; set; }
    }
}
