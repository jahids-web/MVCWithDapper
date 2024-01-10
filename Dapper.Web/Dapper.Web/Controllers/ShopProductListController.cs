using Microsoft.AspNetCore.Mvc;

namespace Dapper.Web.Controllers
{
    public class ShopProductListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
