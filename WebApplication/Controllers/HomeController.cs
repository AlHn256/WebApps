using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ODBCService Service = new ODBCService();

        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Select()
        {
            return View();
        }

        public ActionResult GetMessage()
        {
            return PartialView("GetMessage");
        }

        public ActionResult GetMessage2()
        {
            return PartialView("GetMessage2");
        }

        public ActionResult GetMessage3()
        {
            return PartialView("GetMessage3");
        }

        [HttpPost]
        public string SqlQuery(ConnectionQueryString query)
        {
            if(query.ConnectionString == null) return "ConnectionString is empty!";
            if(query.QueryString == null) return "QueryString is empty!";

            return Service.ODBCConection(query);
        }

        private string StRequest(string href)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(href);
                request.Method = "POST";
                request.ContentType = "text/xml";
                request.Timeout = 10000;
                Stream stream = request.GetResponse().GetResponseStream();

                string html = null;
                using (stream)
                {
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8)) { html = reader.ReadToEnd(); }
                }
                stream.Close();
                return html;
            }
            catch { return null; }
        }


        public ActionResult TestPage()
        {
            

            int[] mass = new int[7] { 1, 2, 3, 4, 5, 8, 7 };
            List<Product> Productes = new List<Product>();
            for (int i = 0; i < 4; i++)
            {
                Product product = new Product
                {
                    Id = i,
                    Name= "Name_"+i*10,
                    Price = i*1230
                };
                Productes.Add(product);
            }

            string txt = "";
            foreach(int elem in mass)
            {
                txt += elem + " ";
            }
            ViewBag.Message = txt;

            Product product2 = new Product
            {
                Id = 25,
                Name = "Banana",
                Price = 2500
            };

            ViewBag.Countries = new List<string> { "Бразилия", "Аргентина", "Уругвай", "Чили" };
            ViewBag.Productes = Productes;
            return View(product2);
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Query()
        {

            var sdf = StRequest("https://www.tutorialstonight.com/lib/examples/students.json");
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }






    }
}