using System.Web.Mvc;

namespace ViewWithoutController.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


    }
}