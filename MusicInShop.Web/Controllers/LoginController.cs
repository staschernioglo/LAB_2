﻿//using AutoMapper;
using MusicInShop.BusinessLogic;
using MusicInShop.BusinessLogic.Interfaces;
using MusicInShop.Domain.Entities.User;
using MusicInShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicInShop.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private readonly ISession _session;
        public LoginController()
        {
            var bl = new MyBusinessLogic();
            _session = bl.GetSessionBL();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                ULoginData data = new ULoginData
                {
                    Credential = login.Credential,
                    Password = login.Password,
                    LoginIp = Request.UserHostAddress,
                    LoginDateTime = DateTime.Now
                };

                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    //ADD COOKIE

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View();
                }

            }

            return View();
        }
    }
}