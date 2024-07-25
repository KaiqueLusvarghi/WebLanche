using Microsoft.AspNetCore.Mvc;
using WebLanches.Models;
using WebLanches.ViewModels;

namespace WebLanches.Components;

public class CarrinhoCompraResumo : ViewComponent
{
    private readonly CarrinhoCompra _carrinhoCompra;

    public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
    {
        _carrinhoCompra = carrinhoCompra;
    }

    public IViewComponentResult Invoke()
    {
        var itens = _carrinhoCompra.GetCarrinhoCompraItems();
        //var itens = new List<CarrinhoCompraItem>() 
        //{
        //    //Simulando carrinho de compra fake
        //    new CarrinhoCompraItem(),
        //    new CarrinhoCompraItem()
        //};
        _carrinhoCompra.CarrinhoCompraItems = itens;

        var carrinhoCompraVM = new CarrinhoCompraViewModel
        {
            CarrinhoCompra = _carrinhoCompra,
            CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
        };
        return View(carrinhoCompraVM);
    }
}
