using Microsoft.AspNetCore.Mvc;

namespace Dapper.Web.Controllers
{
    public class CategorieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
