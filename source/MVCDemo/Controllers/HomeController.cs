﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers {
    public class HomeController : Controller {
        //
        // -- Contensive addons
        [ValidateInput(false)]
        public ActionResult Contensive() {
            using (var cp = new Contensive.Processor.CPClass(System.Web.Hosting.HostingEnvironment.SiteName, System.Web.HttpContext.Current)) {
                return Content(cp.executeRoute());
            }
        }
        //
        public ActionResult Index() {


            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}