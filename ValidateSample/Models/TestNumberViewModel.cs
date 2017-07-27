using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidateSample.Models
{
    public class TestNumberViewModel
    {
        [MaxLength(3)]
        //[StringLength(3)] 
        public string 最大三位數 { get; set; }

        [MinLength(3)]
        //[StringLength(Int32.MaxValue, MinimumLength = 3)] 
        public string 最小三位數 { get; set; }

        [Range(10, 99999)]
        //[StringLength(5, MinimumLength = 2)]
        public string 最小兩位數最大五位數 { get; set; }

        [Range(0, 255)]
        public byte 整數byte範圍 { get; set; }

        [Range(-32768, 32767)]
        public int 數值Int範圍 { get; set; }


        [Range(int.MinValue, int.MaxValue)]
        public int 數值Int範圍2 { get; set; }
    }
}