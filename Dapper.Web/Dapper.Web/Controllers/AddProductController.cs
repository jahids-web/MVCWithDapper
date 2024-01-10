using Microsoft.AspNetCore.Mvc;

namespace Dapper.Web.Controllers
{
    public class AddProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
