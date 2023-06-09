﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy_Core_Proje.Areas.Writer.Models;

namespace Udemy_Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
           
                WriterUser w = new WriterUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    UserName = p.UserName,
                    Email = p.Mail,
                    ImageUrl = p.ImageUrl
                };
            if (p.Password==p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(w, p.Password);


                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(p);
        }
    }
}
