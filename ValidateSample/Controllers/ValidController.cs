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

        public JsonResult CheckUserName(string userName)
        {

            bool isValidate = false;
            if (userName.ToUpper().IndexOf("SKILLTREE") == -1 &&
                userName.ToUpper().IndexOf("DEMO") == -1 &&
                userName.ToUpper().IndexOf("TWMVC") == -1)
            {
                isValidate = true;
            }

            // Remote 驗證是使用 Get 因此要開放
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }


}
