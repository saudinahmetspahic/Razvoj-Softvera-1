﻿using Microsoft.AspNetCore.Mvc;

namespace RS1_2019_12_02.Controllers
{
    public class AjaxTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AjaxTestAction()
        {
            return PartialView("_AjaxTestView");
        }
    }
}