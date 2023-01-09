using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn_PetShop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string tk, string mk)
        {
            bool kt = (tk.Equals("admin") && mk.Equals("123"));
            if (kt)
            {
                return RedirectToAction("Index", "DashBoard", new { Area = "Admin" });
            }
            else
            {
                ModelState.AddModelError("", "Tài khoản hoặc mật khẩu sai, vui lòng kiểm tra lại");
            }
            return View();
        }
    }
}