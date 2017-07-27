using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ValidateSample.Controllers
{
    public class ImageUploadController : Controller
    {
        // GET: ImageUpload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase upload)
        {
            var success = true;
            #region 只檢查附檔名的作法
            //檢查附檔名
            //檢查檔案格式（只檢查附檔名並不安全）
            if (upload != null && !Regex.IsMatch(upload.FileName, @"\.(jpg|jpeg|gif|png)$"))
            {
                ModelState.AddModelError("", "僅可上傳圖片檔");
                success = false;
            }
            #endregion

            #region 安全等級較高的檢查法（圖片適用）

            if (upload != null)
            {
                try
                {
                    var imgStream = new MemoryStream();
                    upload.InputStream.CopyTo(imgStream);
                    var img = new WebImage(imgStream);
                    img = null;
                    imgStream.Dispose();
                }
                catch (Exception)
                {
                    success = false;
                    ModelState.AddModelError("", "必需為圖片");
                }
            }
            #endregion

            return Content(success.ToString());
        }
    }
}