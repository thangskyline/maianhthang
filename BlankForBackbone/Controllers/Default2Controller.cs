﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlankForBackbone.Controllers
{
    public class Default2Controller : Controller
    {
        //
        // GET: /Default2/

        public ActionResult Index()
        {
            int b = 12;
            int c = 1;
            return View();
        }

    }
}
