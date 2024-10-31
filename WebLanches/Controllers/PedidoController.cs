using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebLanches.Models;
using WebLanches.Repositories.Interfaces;

namespace WebLanches.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _PedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _PedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Checkout()
        { 
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Checkout(Pedido pedido) 
        {
            int totalItensPedido = 0;
            decimal precoTotalPedido = 0.0m;

            //Obtem os itens do casrrinho de compra do cliente 
            List<CarrinhoCompraItem> items = _carrinhoCompra.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = items;

            //Verificar se existem itens de pedido
            if (_carrinhoCompra.CarrinhoCompraItems.Count == 0)
            {
                ModelState.AddModelError("", "Seu Carrinho está vazio, que tal fazer um pedido...?");
            }

            //calcular o total de itens e o total do pedido
            foreach(var item in items)
            {
                totalItensPedido += item.Quantidade;
                precoTotalPedido += (item.Lanche.Preco * item.Quantidade);
            }
            
            //atribuir os valores obtidos ao pedido
            pedido.TotalItensPedido = totalItensPedido;
            pedido.PedidoTotal = precoTotalPedido;

            //Validar os dados do pedido
            if (ModelState.IsValid)
            {
                //Criar o pedido e o detalhe dos pedidos
                _PedidoRepository.CriarPedido(pedido);

                //define mensagens ao cliente
                ViewBag.CheckoutCompletoMensagem = "Obrigado pelo seu pedido :)";
                ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoCompraTotal();

                //limpar o carrino do cliente
                _carrinhoCompra.LimparCarrinho();

                //exibindo a view com dados do cliente e do pedido
                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
            }
            return View(pedido);
        }
    }
}
