using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidateSample.Controllers
{
    public class ValidController : Controller
    {
        //public ActionResult Index(string name, string age)
        //{
        //    bool isValidate = name == "skilltree" ;
        //    return Json(isValidate, JsonRequestBehavior.AllowGet);
        //}
        public ActionResult Index(string name, string age)
        {
            bool isValidate = true;

            if (name == "skilltree" || name == "demo" || name == "twMVC")
            {
                isValidate = false;
            }
           // bool isValidate = name == "skilltree";
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }


    }
}