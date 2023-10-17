using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLThuVien.Models;

namespace QLThuVien.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult DangNhap()
        {
            return View();
        }
        public ActionResult TraCuuSach()
        {
            return View();
        }
    }
}