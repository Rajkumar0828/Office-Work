using APICrudclient.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICrudclient.Controllers
{
   public class ProductController : Controller


   {

        private readonly APIGateway _apiGateway;
    public  ProductController(APIGateway ApiGateway)
    {
        _apiGateway = ApiGateway;
    }



    public IActionResult Index()
    {
        List<ProductModel> product;

        product = _apiGateway.ListProducts();
        return View(product);
    }

   }
}