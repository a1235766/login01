using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ganss.XSS;
using Microsoft.Security.Application;
using ValidateSample.Models;

namespace ValidateSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Type()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Type(TestTypeViewModel data)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(data);
        }

        public ActionResult Base()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Base(TestBaseViewModel data)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(data);
        }
        public ActionResult Format()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Format(TestFormatViewModel data)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(data);
        }
        public ActionResult Number()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Number(TestNumberViewModel data)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(data);
        }

        public ActionResult Regex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Regex(TestRegexViewModel data)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(data);
        }
        public ActionResult Remote()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Remote(TestRemoteViewModel data)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(data);
        }

        public ActionResult HtmlTest()
        {
            return View();
        }

        [HttpPost]
        //[ValidateInput(false)]
        public ActionResult HtmlTest(TestHtmlViewModel data)
        {
            ViewData["a"] = data.AllowHtml;
            ViewData["d"] = data.DesAllowHtml;

            //ViewData["a"] = Sanitizer.GetSafeHtmlFragment(data.AllowHtml);
            //ViewData["d"] = data.DesAllowHtml;

            #region HtmlSanitizer 範例
            //var sanitizer = new HtmlSanitizer();
            //sanitizer.AllowedAttributes.Add("class");
            //sanitizer.AllowedAttributes.Add("id");
            //ViewData["a"] = sanitizer.Sanitize(data.AllowHtml);
            //ViewData["d"] = data.DesAllowHtml;

            #endregion


            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }


        public ActionResult login01()
        {
            if (ModelState.IsValid)
            {
                return View();
            }

            return Content("登入成功");
        }

        //public ActionResult login01()
        //{
        //    return View();
        //}

        //[HttpPost]

        //public ActionResult login01(FormatViewModel data)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    return View(data);
        //}



        [HttpPost]
        //[ValidateInput(false)]
        public ActionResult login01(FormatViewModel data)
        {

            if (ModelState.IsValid)
            {
                return Content("登入成功");

            }

            return View();


        }



    }
}