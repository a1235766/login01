using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidateSample.Models
{
    public class TestRegexViewModel
    {
        [RegularExpression(@"\w{0,3}")]
        public string 最大三位數 { get; set; }

        [RegularExpression(@"\w{2,5}")]
        public string 最小兩位數最大五位數 { get; set; }

        [RegularExpression(@"\w+[@]\w+.\w+")]
        public string 電子郵件 { get; set; }
    }
}