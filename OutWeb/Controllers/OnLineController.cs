using System.Web.Mvc;

namespace Work.WebProj.Controllers
{
    public class OnLineController : Controller
    {
        public OnLineController()
        {
            ViewBag.IsFirstPage = false;
        }

        public ActionResult Index()
        {
            return View("OnLine");
        }

        // 套程式-線上諮詢
        public ActionResult OnLine()
        {
            return View();
        }
    }
}