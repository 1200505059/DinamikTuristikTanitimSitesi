using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Entity;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DBTRABZONEntities4 db=new DBTRABZONEntities4();
        [HttpGet]
        public ActionResult Index()
        {
            var degerler=db.TBLADMİN.ToList();
            return View(degerler);
        }
		[HttpPost]
		public ActionResult Index(TBLADMİN p)
		{
            var login = db.TBLADMİN.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
            return RedirectToAction("Index", "Admin");
		}
	}
}