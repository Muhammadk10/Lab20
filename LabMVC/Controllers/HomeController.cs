﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A brief biography.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Muhammad's Work";

            return View();
        }

        
    }
}