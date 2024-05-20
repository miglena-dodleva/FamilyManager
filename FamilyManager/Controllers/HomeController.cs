using FamilyManager.ActionFilters;
using FamilyManager.Entities;
using FamilyManager.ExtensionMethods;
using FamilyManager.Models;
using FamilyManager.Repositories;
using FamilyManager.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FamilyManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (!this.ModelState.IsValid)
                return View(model);

            UsersRepository repo = new UsersRepository();
            User loggedUser = repo.FirstOrDefault(u =>
                                      u.Username == model.Username &&
                                      u.Password == model.Password
            );

            if (loggedUser == null)
                return RedirectToAction("Register", "Home");

            HttpContext.Session.SetObject("loggedUser", loggedUser);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterVM model)
        {
            if (!this.ModelState.IsValid)
                return View(model);

            UsersRepository repo = new UsersRepository();
            
            var existingUser = repo.FirstOrDefault(u => u.Username == model.Username || u.Email == model.Email);
            if (existingUser != null)
            {
                ModelState.AddModelError("registerError", "Username or Email already exists.");
                return View(model);
            }

            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Username = model.Username,
                Password = model.Password,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                FamilyId = model.FamilyId
            };

            var registeredUser = repo.FirstOrDefault(x =>
                x.FirstName == model.FirstName &&
                x.LastName == model.LastName &&
                x.Username == model.Username &&
                x.Password == model.Password);

            if (registeredUser != null)
                return this.View(model);

            repo.Add(user);
            repo.SaveChanges();

            HttpContext.Session.SetObject("loggedUser", registeredUser);

            return RedirectToAction("Index", "Home");
        }


        [AuthenticationFilter]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("loggedUser");

            return RedirectToAction("Login", "Home");
        }
    }
}
