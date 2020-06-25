using System;

namespace Dominio
{
    public class BuscaPedido
    {
        public int? IdCliente { get; set; }

        public int? NumeroPedido { get; set; }

        public DateTime? DataInicial { get; set; }
                       
        public DateTime? DataFinal { get; set; }
    }
}
