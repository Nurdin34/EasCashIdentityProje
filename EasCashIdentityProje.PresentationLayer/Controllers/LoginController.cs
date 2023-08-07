﻿using EasCashIdentityProje.EntityLayer.Concrete;
using EasCashIdentityProje.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasCashIdentityProje.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            var result=await _signInManager.PasswordSignInAsync
                (loginViewModel.UserName, loginViewModel.Password,false,true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
                if(user.EmailConfirmed == false)
                {
                    return RedirectToAction("Index", "MyProfile");
                }
                return RedirectToAction("Index", "MyProfile");
            }
            return View();
        }
    }
}
