using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidateSample.Models
{
    public class TestFormatViewModel
    {
        [EmailAddress]
        public string 電子郵件 { get; set; }

        [Url]
        public string 網址 { get; set; }

        [Url]
        public string 圖片位置 { get; set; }

        [CreditCard]
        public string 信用卡號碼 { get; set; }
    }
}