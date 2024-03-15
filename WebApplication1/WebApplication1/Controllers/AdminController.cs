using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Entity;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DBTRABZONEntities4 db= new DBTRABZONEntities4();
       /*****************GİRİŞ İŞLEMLERİ*************************/
        public ActionResult Index()
        {
            var deger=db.TBLGİRİS.ToList();
            return View(deger);
        }
        public ActionResult GirisSil(int id) 
        {
            var sil = db.TBLGİRİS.Find(id);
            db.TBLGİRİS.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
		public ActionResult GirisEkle()
		{
            return View();
		}

		public ActionResult GirisEkle(TBLGİRİS p) 
        { 
            var ekle=db.TBLGİRİS.Add(p);
            db.SaveChanges();
			return RedirectToAction("Index");
		}
        [HttpGet]
        public ActionResult GirisGuncelle(int id)
        {
            var guncelle=db.TBLGİRİS.Find(id);
            return View(guncelle);
        }
        [HttpPost]
        public ActionResult GirisGuncelle(TBLGİRİS p) {
            var guncelle=db.TBLGİRİS.Find(p.GirisID);
            guncelle.GirisID = p.GirisID;
            guncelle.GirisBaslik=p.GirisBaslik;
            guncelle.GirisMetin=p.GirisMetin;
            db.TBLGİRİS.AddOrUpdate(guncelle);
            db.SaveChanges();
			return RedirectToAction("Index");
		}
		/*****************TARİH İŞLEMLERİ*************************/
        public ActionResult Tarih() {
            var  tarih=db.TBLKULTUR.ToList();
            return View(tarih);

        }
        public ActionResult Tarihsil(int id)
        {
            var sil= db.TBLKULTUR.Find(id);
            db.TBLKULTUR.Remove(sil);
            db.SaveChanges();
			return RedirectToAction("Tarih");
		}
        [HttpGet]
        public ActionResult TarihEkle()
        {
            return View();
        }
        [HttpPost]
		public ActionResult TarihEkle(TBLKULTUR p)
		{
            var ekle=db.TBLKULTUR.Add(p);
            db.SaveChanges();
			return RedirectToAction("Tarih");
		}
        [HttpGet]
        public ActionResult TarihGuncelle(int id)
        {
            var guncelle=db.TBLKULTUR.Find(id);
            return View(guncelle);
        }
        [HttpPost]
        public ActionResult TarihGuncelle(TBLKULTUR p)
        {
			var guncelle=db.TBLKULTUR.Find(p.KulturID);
            guncelle.KulturID=p.KulturID;
            guncelle.KulturBaslik=p.KulturBaslik;
            guncelle.KulturImageURL=p.KulturImageURL;
            guncelle.KulturMetin=p.KulturMetin;
           db.TBLKULTUR.AddOrUpdate(guncelle);
            db.SaveChanges();
            return RedirectToAction("Tarih");

		}
		/*****************DOĞA İŞLEMLERİ*************************/

		public ActionResult Doga()
        {
            var doga=db.TBLDOGA.ToList();
        return View(doga);
        }
        
        public ActionResult DogaSil(int id)
        {
            var sil=db.TBLDOGA.Find(id);
            db.TBLDOGA.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Doga");
        }
        [HttpGet]
        public ActionResult DogaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DogaEkle(TBLDOGA p)
        {
            var ekle= db.TBLDOGA.Add(p);
            db.SaveChanges();

			return RedirectToAction("Doga");
		}
		[HttpGet]
		public ActionResult DogaGuncelle(int id)
		{
            var guncelle=db.TBLDOGA.Find(id);
			return View(guncelle);
		}
		[HttpPost]
		public ActionResult DogaGuncelle(TBLDOGA p)
		{
            var guncelle = db.TBLDOGA.Find(p.DogaID);
            guncelle.DogaID = p.DogaID;
            guncelle.DogaBaslik1 = p.DogaBaslik1;
            guncelle.DogaText=p.DogaText;
            guncelle.DogaImageURL = p.DogaImageURL;
            db.TBLDOGA.AddOrUpdate(guncelle);
            db.SaveChanges();
			return RedirectToAction("Doga");
		}


		/*****************KÜLTÜR İŞLEMLERİ*************************/
		public ActionResult Kultur()
        {
            var kultur=db.TBLTARİH.ToList();
            return View(kultur);
        }
        public ActionResult KulturSil(int id)
        {
            var sil = db.TBLDOGA.Find(id);
            db.TBLDOGA.Remove(sil);
            db.SaveChanges();
			return RedirectToAction("Kultur");
		}
        [HttpGet]
        public ActionResult KulturGuncelle(int id)
        {
            var guncelle=db.TBLTARİH.Find(id);

            return View(guncelle);
        }
		[HttpPost]
		public ActionResult KulturGuncelle(TBLTARİH p)
		{
            var guncelle=db.TBLTARİH.Find(p.TarihID);
            guncelle.TarihID = p.TarihID;
            guncelle.TarihBaslık=p.TarihBaslık;
            guncelle.TarihText=p.TarihText;
            guncelle.TarihImageURL=p.TarihImageURL;
            db.TBLTARİH.AddOrUpdate(guncelle);
            db.SaveChanges();
			return RedirectToAction("Kultur");
		}
		/*****************İLETİŞİM İŞLEMLERİ*************************/
		public ActionResult Iletisim()
        {
            var iletisim=db.TBLILETİSİM.ToList();
            return View(iletisim);
        }
		[HttpGet]
		public ActionResult IletisimGuncelle(int id)
		{
			var guncelle = db.TBLILETİSİM.Find(id);

			return View(guncelle);
		}
		[HttpPost]
		public ActionResult IletisimGuncelle(TBLILETİSİM p)
		{
			var guncelle = db.TBLILETİSİM.Find(p.IletisimID);
			guncelle.IletisimID=p.IletisimID;
            guncelle.Telefon=p.Telefon;
            guncelle.Email=p.Email;
            guncelle.Adres=p.Adres;
            guncelle.TwitterURL=p.TwitterURL;
            guncelle.FacebookURL=p.FacebookURL;
            guncelle.LinkedinURL=p.LinkedinURL;
            guncelle.İnstagramURL = p.İnstagramURL;  
       		db.TBLILETİSİM.AddOrUpdate(guncelle);
			db.SaveChanges();
			return RedirectToAction("Iletisim");
		}
		/*****************ADMİN İŞLEMLERİ*************************/
		public ActionResult Admin()
        {
            var admin=db.TBLADMİN.ToList();
            return View(admin);
        }
        [HttpGet]
        public ActionResult AdminGuncelle(int id)
        {
            var guncelle=db.TBLADMİN.Find(id);
            return View(guncelle);

        }
		[HttpPost]
		public ActionResult AdminGuncelle(TBLADMİN p)
		{
			var guncelle = db.TBLADMİN.Find(p.AdminID);
			guncelle.AdminID = p.AdminID;
            guncelle.AdminUserName = p.AdminUserName;
            guncelle.AdminPassword = p.AdminPassword;
            db.TBLADMİN.AddOrUpdate(guncelle);
            db.SaveChanges();
            return RedirectToAction("Admin");

		}
	}
}