using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ValidateSample.Models
{
    public class AccountInfo
    {
        [Key]
        public int AccountID { get; set; }

        [DisplayName("登入帳號")]
        [Required(ErrorMessage = "請輸入登入帳號")]
        [StringLength(40, ErrorMessage = "登入帳號最多20個字")]
        public string AccountName { get; set; }

        [DisplayName("密碼")]
        [Required(ErrorMessage = "請輸入密碼")]
        [MaxLength(20, ErrorMessage = "密碼最多20個字")]
        [MinLength(8, ErrorMessage = "密碼最少8個字")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("確認密碼")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "密碼與確認密碼不符")]
        public int ConfirePassword { get; set; }

        [DisplayName("姓名")]
        [StringLength(10, ErrorMessage = "姓名最多10個字")]
        public string Name { get; set; }

        [DisplayName("生日")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime BirthDay { get; set; }

        [DisplayName("年齡")]
        [Range(1, 100, ErrorMessage = "年齡請輸入1~100歲")]
        public int Age { get; set; }

        [DisplayName("電子郵件")]
        [EmailAddress(ErrorMessage = "信箱格式錯誤")]
        public string Email { get; set; }

        [DisplayName("個人部落格")]
        [Url(ErrorMessage = "連結格式錯誤")]
        public string BolgUrl { get; set; }

        [DisplayName("薪資")]
        [RegularExpression(@"^d+$", ErrorMessage = "請輸入數字.")]
        public int Salary { get; set; }
    }
}