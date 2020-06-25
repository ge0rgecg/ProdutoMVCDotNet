using Repository.Repositories;
using Service.Services;
using System.Web.Mvc;

namespace BematechMVC.Controllers
{
    public class BaseController : Controller
    {
        public ClienteService _clienteService;
        public ClienteRepository _clienteReposiroty;
        public ProdutoService _produtoService;
        public ProdutoRepository _produtoRepository;
        public PedidoItemService _pedidoItemService;
        public PedidoItemRepository _pedidoItemRepository;
        public PedidoService _pedidoService;
        public PedidoRepository _pedidoRepository;

        public BaseController()
        {
            _clienteReposiroty = new ClienteRepository();
            _produtoRepository = new ProdutoRepository();
            _pedidoItemRepository = new PedidoItemRepository();
            _pedidoRepository = new PedidoRepository();
            _clienteService = new ClienteService(_clienteReposiroty);
            _produtoService = new ProdutoService(_produtoRepository);
            _pedidoItemService = new PedidoItemService(_pedidoItemRepository);
            _pedidoService = new PedidoService(_pedidoRepository);
        }
    }
}
