﻿using DataAccess.Concrete.Context;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.UI.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Writer writer)
        {
            Context context = new Context();
            var dataValue = context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.WriterMail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }
        }

    }
}
//Context context = new Context();
//var dataValue = context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
//if (dataValue != null)
//{
//    HttpContext.Session.SetString("username", writer.WriterMail);
//    return RedirectToAction("Index", "Writer");
//}
//else
//{
//    return View();
//}
