using Microsoft.AspNetCore.Mvc;

namespace Dapper_Web.Controllers
{
    public class ShopProductListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
