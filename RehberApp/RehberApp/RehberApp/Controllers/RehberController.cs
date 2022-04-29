using RehberApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RehberApp.Controllers
{
    public class RehberController : Controller
    {
        // Örnek senaryomuza göre veri tabanı
        // telefon rehberine birden fazla kişi
        // ve her kişinin de birden fazla numarası
        // eklenebilecek şekilde tasarlanmıştır.
        public ActionResult Index()
        {
            RehberContext context = new RehberContext();
            var data = context.Directory.Where(x => x.userId == 1).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult YeniEkle()
        {

            return View(new PhoneNumber());
        }

        [HttpPost]
        public ActionResult YeniEkle(PhoneNumber phoneNumber)
        {
            RehberContext context = new RehberContext();
            context.PhoneNumber.Add(phoneNumber);
            context.SaveChanges();

            Directory directory = new Directory() { 
            userId=1,
            recordedUserId=phoneNumber.userId
            };
            context.Directory.Add(directory);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Ekle(int id)
        {
            PhoneNumber phoneNumber = new PhoneNumber()
            {
                userId=id
            };


            return View(phoneNumber);
        }

        [HttpPost]
        public ActionResult Ekle(PhoneNumber phoneNumber)
        {
            RehberContext context = new RehberContext();
            context.PhoneNumber.Add(phoneNumber);
            context.SaveChanges();

           
            return RedirectToAction("Index");
        }
    }
}