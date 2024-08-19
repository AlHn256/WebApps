using System;
using System.Web;
using System.Web.Mvc;


namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        #region Forms
        public ActionResult Forms1()
        {
            return View();
        }
        public ActionResult Forms2()
        {
            ViewBag.UserName = Request.Form["userName"];
            return View();
        }
        public ActionResult Forms3()
        {
            ViewBag.UserName = Request.Form["userName"];
            ViewBag.FoodName = Request.Form["foodName"];
            //Сохранить заказ в БД для данного пользователя...
            return View();
        }
        #endregion

        #region Cookies
        public ActionResult Cookies1()
        {
            return View();
        }
        public ActionResult Cookies2()
        {
            HttpCookie cookie = new HttpCookie("userName", HttpUtility.UrlEncode(Request.Form["userName"]));
            cookie.Expires = DateTime.UtcNow.AddHours(1);
            Response.Cookies.Add(cookie);

            return View();
        }
        public ActionResult Cookies3()
        {
            HttpCookie cookie = new HttpCookie("foodName", HttpUtility.UrlEncode(Request.Form["foodName"]));
            cookie.Expires = DateTime.UtcNow.AddHours(1);
            Response.Cookies.Add(cookie);

            //Сохранить заказ в БД для данного пользователя...

            return View();
        }
        #endregion

        #region Session
        public ActionResult Session1()
        {
            return View();
        }
        public ActionResult Session2()
        {
            Session["userName"] = Request.Form["userName"];
            return View();
        }
        public ActionResult Session3()
        {
            if (Session["foodName"] == null)
                Session["foodName"] = Request.Form["foodName"];
            return View();
        }
        #endregion
    }
}