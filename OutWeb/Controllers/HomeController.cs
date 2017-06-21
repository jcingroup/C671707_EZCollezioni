using System.Web.Mvc;

namespace OutWeb.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            ViewBag.IsFirstPage = false;
        }

        // all 靜態
        public ActionResult Index()
        {
            ViewBag.IsFirstPage = true;
            return View();            
        }

        // 品牌故事
        public ActionResult About()
        {
            return View();
        }

        // 男士精品
        public ActionResult Show_S1()
        {
            return View();
        }

        // 訂製流程
        public ActionResult Flow()
        {
            return View();
        }

        // 選擇ez的10大理由
        public ActionResult Best_choice()
        {
            return View();
        }

        // 領帶的打法
        public ActionResult TieKnot()
        {
            return View();
        }

        // 西服保養技巧
        public ActionResult Maintain()
        {
            return View();
        }

        // 新婚賀禮大方送
        public ActionResult Wedding()
        {
            return View();
        }

        // 滿額禮優惠活動
        public ActionResult Event()
        {
            return View();
        }

        // 客戶服務
        public ActionResult Service()
        {
            return View();
        }

        // 版權聲明
        public ActionResult Copyright()
        {
            return View();
        }
    }
}