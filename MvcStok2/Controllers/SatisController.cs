﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok2.Models.Entity;

namespace MvcStok2.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        MvcDbStokEntities1 db = new MvcDbStokEntities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(TBLSATISLAR p1)
        {
            db.TBLSATISLAR.Add(p1);
            db.SaveChanges();
            return View("Index");
        }
    }
}