﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eGasClientFinalR51.Controllers
{
    public class InstructorController : Controller
    {

        public InstructorController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }
        private readonly SignInManager<IdentityUser> _signInManager;
        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User)) //verify if it's logged
            {
                return View();// LocalRedirect("~/Page");
            }
            else
                return LocalRedirect("~/");
        }

    }
}
