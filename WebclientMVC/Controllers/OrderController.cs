using APICrudclient.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICrudclient.Controllers
{
   public class OrderController : Controller


   {

        private readonly APIGateway _apiGateway;
    public  OrderController(APIGateway ApiGateway)
    {
        _apiGateway = ApiGateway;
    }



    public IActionResult Index()
    {
        List<OrderModel> order;

        order = _apiGateway.ListOrder();
        return View(order);
    }

   }
}