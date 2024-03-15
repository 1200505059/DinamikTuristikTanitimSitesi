using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Entity;

namespace WebApplication1.Controllers
{
    public class DogaController : Controller
    {
        DBTRABZONEntities4 db=new DBTRABZONEntities4();
        public ActionResult Index()
        {
            var degerler=db.TBLDOGA.ToList();
            return View(degerler);
        }

    }
}