using FamilyManager.ActionFilters;
using FamilyManager.Entities;
using FamilyManager.Repositories;
using FamilyManager.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace FamilyManager.Controllers
{
    [AuthenticationFilter]
    public class UsersController : Controller
    {

        [HttpGet]
        public IActionResult Index(IndexVM model)
        {
            UsersRepository repo = new UsersRepository();   

            model.Filter = model.Filter ?? new FilterVM();

            Expression<Func<User, bool>> filter = u =>
            (string.IsNullOrEmpty(model.Filter.Username) || u.Username.Contains(model.Filter.Username)) &&
            (string.IsNullOrEmpty(model.Filter.FirstName) || u.FirstName.Contains(model.Filter.FirstName)) &&
            (string.IsNullOrEmpty(model.Filter.LastName) || u.LastName.Contains(model.Filter.LastName));

            model.Items = repo.GetAll(filter,
                                      i => i.Id
            );

            return View(model);
        }

        [HttpGet]
        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User item = new User();
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;
            item.PhoneNumber = model.PhoneNumber;

            UsersRepository repo = new UsersRepository();
            repo.Save(item);

            return RedirectToAction("Index", "Users");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            UsersRepository repo = new UsersRepository();
            User item = repo.FirstOrDefault(u => u.Id == id);

            if (item == null)
                return RedirectToAction("Index", "Users");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            model.Email = item.Email;
            model.PhoneNumber = item.PhoneNumber;   

            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User item = new User();
            item.Id = model.Id;
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;
            item.PhoneNumber = model.PhoneNumber;   

            UsersRepository repo = new UsersRepository();
            repo.Save(item);

            return RedirectToAction("Index", "Users");
        }


        public IActionResult Delete(int id)
        {
            UsersRepository repo = new UsersRepository();
            User item = new User();
            item.Id = id;

            repo.Delete(item);

            return RedirectToAction("Index", "Users");
        }
    }

}
