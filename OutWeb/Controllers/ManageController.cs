using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutWeb.Controllers
{
    public class ManageController : Controller
    {
        public ManageController()
        {
            ViewBag.IsFirstPage = false;
        }

        // GET: Manage
        public ActionResult Index()        {
            
            return View("Login");
        }

        // 登入頁
        public ActionResult Login()
        {
            return View();
        }

        // 最新消息
        public ActionResult NewsList()
        {
            return View();
        }
        public ActionResult NewsData()
        {
            return View();
        }

        // 常見問題
        public ActionResult FAQList()
        {
            return View();
        }
        public ActionResult FAQData()
        {
            return View();
        }

        // 線上諮詢
        public ActionResult OnLine()
        {
            return View();
        }

        // 修改密碼
        public ActionResult ChangePW()
        {
            return View();
        }
    }
}