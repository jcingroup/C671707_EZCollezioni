using System.Web.Mvc;

namespace Work.WebProj.Controllers
{
    public class QandAController : Controller
    {
        public QandAController()
        {
            ViewBag.IsFirstPage = false;
        }

        public ActionResult Index()
        {
            return View("QandA");
        }

        // 套程式-常見問題
        public ActionResult QandA()
        {
            return View();
        }
    }
}