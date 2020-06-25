using System.Globalization;

namespace Dominio
{
    public class PedidoItem
    {
        public PedidoItem()
        {
            Produto = new Produto();
        }

        public PedidoItem(string quantidade, int produto_Id, string valorTotal)
        {
            decimal valor = 0;
            decimal.TryParse(quantidade, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out valor);
            this.Quantidade = valor;
            decimal.TryParse(valorTotal, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out valor);
            this.ValorTotal = valor;
            this.Produto_Id = produto_Id;
            //this.Quantidade = quantidade;
            //this.ValorTotal = valorTotal;
        }

        public int Id_PedidoItem { get; set; }
        public decimal Quantidade { get; set; }
        public virtual Produto Produto { get; set; }
        public int Produto_Id { get; set; }
        public int Pedido_Id { get; set; }
        public virtual Pedido Pedido { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
