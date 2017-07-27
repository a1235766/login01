using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidateSample.Filters;

namespace ValidateSample.Models
{
    public class TestHtmlViewModel
    {
        //[AllowHtml]
        public string AllowHtml { get; set; }

        public string DesAllowHtml { get; set; }
    }
}