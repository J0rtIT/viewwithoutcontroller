using System;
using System.Web.Mvc;

namespace ViewWithoutController.Controllers
{
    public class HUController : Controller
    {
        // GET: HU
        public ActionResult Index()
        {
            return View();
        }

        protected override void HandleUnknownAction(string actionName)
        {
            try
            {
                View(actionName).ExecuteResult(ControllerContext);
            }
            catch (Exception ex)
            {
                Response.Redirect("PageNotFound");
            }
            //            base.HandleUnknownAction(actionName);
        }

    }
}