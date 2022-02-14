﻿using BBFReferee.Core.Interfeices;
using BBFReferee.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;

using BBFReferee.Web.Models;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Linq;

namespace BBFReferee.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserViewModelService userViewModelService;
        private readonly IUserService userService;
        private readonly IPasswordHasher passwordHasher;

        public AccountController(IUserViewModelService userViewModelService, IUserService userService, IPasswordHasher passwordHasher)
        {
            this.userViewModelService = userViewModelService;
            this.userService = userService;
            this.passwordHasher = passwordHasher;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(SignInViewModel signIn, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(signIn);
            }

            var user = userService.GetOne(signIn.Login);
            if (user == null || !passwordHasher.IsValid(signIn.Password, user.Password, user.Salt))
            {
                ModelState.AddModelError(string.Empty, "Invalid login or password");
                return View(signIn);
            }

            var claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Name, user.Name));
            claims.AddRange(user.Roles.Select(m => new Claim(ClaimTypes.Role, m.Role.Name)));

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return string.IsNullOrEmpty(returnUrl)
                ? RedirectToAction(nameof(Index), "Home")
                : Redirect(returnUrl);
        }

        [HttpGet]
        public IActionResult Profile(int? id)
        {
            var user = id.HasValue ? userViewModelService.GetById(id.Value) : userViewModelService.GetEmpty();

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Profile(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = user.Id;

            if (id == null || id == 0)
            {
                id = userViewModelService.Add(user);
            }
            else
            {
                userViewModelService.Edit(user);
            }

            return RedirectToAction(nameof(Index), "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(Index), "Home");
        }
    }

}