using System.Web.Mvc;

namespace Book.Store.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("ui/index", "Swagger");
        }
    }
}