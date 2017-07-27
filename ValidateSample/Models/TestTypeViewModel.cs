using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ValidateSample.Filters;

namespace ValidateSample.Models
{
    public class TestTypeViewModel
    {
        public Guid Guid { get; set; }
        public string 文字 { get; set; }

        public int 數值 { get; set; }

        public DateTime 日期 { get; set; }

        public bool 布林 { get; set; }
    }
}