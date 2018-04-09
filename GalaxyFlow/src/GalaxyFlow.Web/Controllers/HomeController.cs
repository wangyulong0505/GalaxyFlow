using Microsoft.AspNetCore.Mvc;

namespace GalaxyFlow.Web.Controllers
{
    public class HomeController : GalaxyFlowControllerBase
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