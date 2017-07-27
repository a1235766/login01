using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;


namespace ValidateSample.Models
{
    public class FormatViewModel
    {
        [EmailAddress]

        [Remote("CheckUserName", "Valid", ErrorMessage = "驗證失敗,帳號不可包含以下字串 skilltree demo twMVC")]
        [Display(Name = "帳號")]
        [Required(ErrorMessage = "請輸入帳號")]
        public string userName { get; set; }


        [EmailAddress]
        public string Email { get; set; }

      
        [StringLength(20, MinimumLength=4)]
        public string 密碼 { get; set; }

        [DisplayName("密碼")]
        [Required(ErrorMessage = "請輸入密碼")]
        [MaxLength(20, ErrorMessage = "密碼最多20個字")]
        [MinLength(4, ErrorMessage = "密碼最少4個字")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

           

    }

 
}