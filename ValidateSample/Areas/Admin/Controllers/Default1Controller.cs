using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidateSample.Models;

namespace ValidateSample.Areas.Admin.Controllers
{
    public class Default1Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TestRemoteViewModel data)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(data);
        }
	}
}