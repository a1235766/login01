using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidateSample.Filters;

namespace ValidateSample.Models
{
    public class TestRemoteViewModel
    {
        [Remote("Index", "Valid", ErrorMessage = "名稱請輸入「skilltree」")]
        //[RemotePlus("Index", "Valid", "", ErrorMessage = "名稱請輸入「skilltree」")]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}