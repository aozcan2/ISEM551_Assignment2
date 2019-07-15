using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISEM551_Assignment2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "You can get in touch with me via:";
            return View();
        }

        public ActionResult DisplayDataWithLayers(){
            var _BusData = BusinessLayerClass.GetDatafromBusinessLayer();
            return View(_BusData);
        }
    }
}