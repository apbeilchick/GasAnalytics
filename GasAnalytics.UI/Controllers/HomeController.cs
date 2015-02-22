using GasAnalytics.DataAccess;
using GasAnalytics.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GasAnalytics.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<FillUpContext>());
                return View();
            }
            catch (Exception)
            {
                throw;
            }
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