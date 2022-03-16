﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan4__VuPhiTruong.Models;
using PagedList;

namespace Tuan4__VuPhiTruong.Controllers
{
    public class HomeController : Controller
    {
        mydataDataContext data = new mydataDataContext();
        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;
            var all_sach = (from s in data.Saches select s).OrderBy(m => m.masach);
            int pagesize = 3;
            int pageNum = page ?? 1;


            return View(all_sach.ToPagedList(pageNum, pagesize));
        }

            public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}