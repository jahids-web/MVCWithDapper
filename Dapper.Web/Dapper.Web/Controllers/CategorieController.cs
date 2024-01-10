using Dapper.Web.Entities;
using Dapper.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Web.Controllers
{
    public class CategorieController : Controller
    {
        private readonly ICategorieServices _categorieServices;

        public CategorieController(ICategorieServices categorieServices)
        {
            _categorieServices = categorieServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public Categorie Insert(Categorie categorie)
        {
            var result = _categorieServices.Insert(categorie);
            return(result);
        }
    }
}
