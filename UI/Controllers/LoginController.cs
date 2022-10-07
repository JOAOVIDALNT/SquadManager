using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SquadManager.Models;
using SquadManager.Validator;
using FluentValidation.Results;

namespace SquadManager.Controllers
{

    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();


            UserValidator validator = new UserValidator();

            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach(var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }

            return View("Index", user);
        }

        [HttpPost]
        public IActionResult Test(UserViewModel user) 
        {
            user.Email = "Email send.";
            
            return View("Index", user);
        }

    }
}