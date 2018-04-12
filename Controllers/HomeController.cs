using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Form_Submission.Models;

namespace Form_Submission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.hasError = false;
            return View();
        }

        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {
            return View();
        }

        [HttpPost]
        [Route("validate")]
        public IActionResult Validate(string FirstName, string LastName, string Age, string Email, string Password)
        {
            Console.WriteLine($"First Name: {FirstName} - Last Name: {LastName} (Age: {Age})\nEmail: {Email}\nPassword: {Password}");
            User NewUser = new User
            {
                FirstName = FirstName,
                LastName = LastName,
                Age = Age,
                Email = Email,
                Password = Password
            };

            TryValidateModel(NewUser);

            if(!ModelState.IsValid)
            {
                ViewBag.hasError = true;
                ViewBag.errors = ModelState.Values;
                Console.WriteLine(ViewBag.errors);
                return View("Index");
            }
            
            return RedirectToAction("success");
        }

    }
}
