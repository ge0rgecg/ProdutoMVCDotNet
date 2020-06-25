using System;
using System.Linq;
using System.Collections.Generic;
using Dominio;
using Repository.Interface;
using Service.Interface;

namespace Service.Services
{
    public class PedidoService : ServiceBase<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
            : base(pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IEnumerable<Pedido> GetByModel(BuscaPedido filtro)
        {
            IEnumerable<Pedido> retorno =_pedidoRepository.GetAll();

            if(filtro.DataFinal.HasValue && filtro.DataInicial.HasValue)
            {
                retorno = retorno.Where(w => w.DataEntrega >= filtro.DataInicial.Value && w.DataEntrega <= filtro.DataFinal.Value);
            }

            if(filtro.IdCliente.HasValue)
            {
                retorno = retorno.Where(w => w.Cliente_Id == filtro.IdCliente.Value);
            }

            if(filtro.NumeroPedido.HasValue)
            {
                retorno = retorno.Where(w => w.Id_Pedido == filtro.NumeroPedido.Value);
            }

            return retorno;
        }
    }
}