using Dominio;
using Repository.Interface;
using Service.Interface;

namespace Service.Services
{
    public class PedidoItemService : ServiceBase<PedidoItem>, IPedidoItemService
    {
        private readonly IPedidoItemRepository _pedidoItemRepository;

        public PedidoItemService(IPedidoItemRepository pedidoItemRepository)
            : base(pedidoItemRepository)
        {
            _pedidoItemRepository = pedidoItemRepository;
        }
    }
}