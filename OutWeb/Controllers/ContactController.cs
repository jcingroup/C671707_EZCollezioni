using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutWeb.Controllers
{
    public class ContactController : Controller
    {
        public ContactController()
        {
            ViewBag.IsFirstPage = false;
        }

        // all靜態-門市資訊
        public ActionResult Index()
        {
            return View("Taipei_concept");
        }

        // 台北概念店
        public ActionResult Taipei_concept()
        {
            return View();
        }

        // 台北西門店
        public ActionResult Con_Xi_Men()
        {
            return View();
        }

        // 台北光復店
        public ActionResult Con_Guang_Fu()
        {
            return View();
        }

        // 桃園復興店
        public ActionResult Con_Tao_Yuan()
        {
            return View();
        }

        // 新竹形象概念店
        public ActionResult Hsin_chu_concept()
        {
            return View();
        }

        // 新竹中華店
        public ActionResult Con_Hsin_Chu()
        {
            return View();
        }

        // 台中英才店
        public ActionResult Con_San_Min()
        {
            return View();
        }

        // 台南中正店
        public ActionResult Con_Tai_Nan()
        {
            return View();
        }

        // 高雄中正店
        public ActionResult Con_Zhong_Zheng()
        {
            return View();
        }
    }
}