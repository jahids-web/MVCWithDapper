using Microsoft.AspNetCore.Mvc;

namespace Dapper_Web.Controllers
{
    public class CategorieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
