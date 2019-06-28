using Microsoft.AspNetCore.Mvc;

namespace Neppure.Plant.Web.Controllers
{
    public class HomeController : PlantControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}