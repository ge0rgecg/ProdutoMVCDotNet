using BematechMVC.Models;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BematechMVC.Controllers
{
    public class PedidoController : BaseController
    {
        // GET: Pedido
        public ActionResult Index()
        {
            BuscaPedidoViewModel model = new BuscaPedidoViewModel();
            model.ListaCliente.AddRange(new SelectList(_clienteService.GetAll(), "Id_Cliente", "Nome"));
            model.ListaPedidos = _pedidoService.GetAll();
            return View(model);
        }

        public ActionResult CriarPedido()
        {
            CriarPedidoViewModel model = new CriarPedidoViewModel();
            model.ListaCliente.AddRange(new SelectList(_clienteService.GetAll(), "Id_Cliente", "Nome"));
            model.ListaProduto.AddRange(new SelectList(_produtoService.GetAll(), "Id_Produto", "Descricao"));
            return View(model);
        }

        [HttpPost]
        public ActionResult CriarPedido(CriarPedidoViewModel model)
        {
            try
            {
                if (model.DataEntrega.HasValue) {
                    Pedido pedido = new Pedido();
                    pedido.DataEntrega = model.DataEntrega.Value;
                    if (model.IdCliente != -1) {
                        pedido.Cliente_Id = model.IdCliente;
                    }
                    else
                    {
                        pedido.Cliente = null;
                    }
                    pedido.ListaProduto = model.PedidoItem.Select(s => new PedidoItem(s.Quantidade, s.Produto.IdProduto, s.ValorTotal)).ToList();
                    pedido.ValorTotal = pedido.ListaProduto.Sum(s => s.ValorTotal);
                    _pedidoService.Add(pedido);
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                model.ListaCliente.AddRange(new SelectList(_clienteService.GetAll(), "Id_Cliente", "Nome"));
                model.ListaProduto.AddRange(new SelectList(_produtoService.GetAll(), "Id_Produto", "Descricao"));
                return View(model);
            }
        }

        [HttpPost]
        public JsonResult ObterProduto(int IdProduto)
        {
            var produto = _produtoService.GetById(IdProduto);
            return Json(produto);
        }

        [HttpPost]
        public JsonResult ObterPedidos(BuscaPedidoViewModel model)
        {
            BuscaPedido buscaPedido = new BuscaPedido();
            buscaPedido.DataFinal = model.DataFinal;
            buscaPedido.DataInicial = model.DataInicial;
            buscaPedido.IdCliente = model.IdCliente;
            buscaPedido.NumeroPedido = model.IdPedido;
            var pedidos = _pedidoService.GetByModel(buscaPedido);
            IEnumerable<ListaBuscaPedidoViewModel> retorno = new List<ListaBuscaPedidoViewModel>();
            retorno = pedidos.Select(s => new ListaBuscaPedidoViewModel(s.Id_Pedido.ToString(), s.Cliente != null ? s.Cliente.Nome : "Cliente Generico", s.ValorTotal)).ToList();
            return Json(retorno);
        }
    }
}
