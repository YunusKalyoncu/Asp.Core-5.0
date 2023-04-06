﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy_Core_Proje.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Service Listesi";
            ViewBag.v2 = "Serviceler";
            ViewBag.v3 = "Service Listeleme";
            var values = serviceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Service Ekleme";
            ViewBag.v2 = "Serviceler";
            ViewBag.v3 = "Service Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            
            serviceManager.TAdd(service);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Service Güncelleme";
            ViewBag.v2 = "Serviceler";
            ViewBag.v3 = "Service Güncelleme";
            var values = serviceManager.TGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetByID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");


        }

    }
}
