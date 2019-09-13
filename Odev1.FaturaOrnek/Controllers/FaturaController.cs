using Odev1.FaturaOrnek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev1.FaturaOrnek.Controllers
{
    public class FaturaController : Controller
    {
        // GET: Fatura
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listele()
        {
            
            var liste = new List<Fatura>()
            {
                new Fatura()
                {

                    FaturaID=1,
                    KullaniciID=1234,
                   
                    GenelToplam=1500,
                    Onaylandi=false,
                    Yazdirildi=false,
                    

                },
                  new Fatura()
                {

                    FaturaID=2,
                    KullaniciID=9876,
                    
                    GenelToplam=3600,
                    Onaylandi=true,
                    Yazdirildi=false,

                }
            };
            return View(liste);
        }
        public ActionResult Detay()
        {
            return View();
        }
        public ActionResult Kaydet()
        {
            return View();
        }
        public ActionResult Duzenle()
        {
            return View();
        }
    }
}