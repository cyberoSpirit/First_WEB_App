﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class HistoryController : Controller
    {
        // GET: History
        public ActionResult Index()
        {
            return View();
        }
    }
}