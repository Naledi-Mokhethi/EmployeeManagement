﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDapperDBEntities db = new EmployeeDapperDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.tbl_Registration.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}