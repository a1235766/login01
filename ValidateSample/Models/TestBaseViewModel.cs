using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ValidateSample.Filters;

namespace ValidateSample.Models
{
    public class TestBaseViewModel
    {
        //[Required]
        //[Required(AllowEmptyStrings = false)]
        public string 必填文字 { get; set; }

        //[StringLength(5)]
        //[StringLength(5,MinimumLength=3)]
        public string 文字 { get; set; }

        //[UIHint("password")] 這不是驗證
        public string 密碼 { get; set; }

        //[Compare("密碼")]
        public string 確認密碼 { get; set; }

    }
}

//[BanWord("test")]