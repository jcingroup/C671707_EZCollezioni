using System.Web.Mvc;

namespace OutWeb.Controllers
{
    public class NewsController : Controller
    {
        public NewsController()
        {
            ViewBag.IsFirstPage = false;
        }

        public ActionResult Index()
        {
            return View("News");
        }

        // 套程式-最新消息
        public ActionResult News()
        {
            return View();
        }        
    }
}