using Dominio;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IPedidoService : IServiceBase<Pedido>
    {
        IEnumerable<Pedido> GetByModel(BuscaPedido filtro);
    }
}