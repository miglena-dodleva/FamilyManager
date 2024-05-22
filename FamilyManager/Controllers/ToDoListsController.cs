using FamilyManager.ActionFilters;
using FamilyManager.Entities;
using FamilyManager.Repositories;
using FamilyManager.ViewModels.ToDoLists;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace FamilyManager.Controllers
{
    [AuthenticationFilter]
    public class ToDoListsController : Controller
    {
        [HttpGet]
        public IActionResult Index(IndexVM model)
        {
            ToDoListsRepository repo = new ToDoListsRepository();

            model.Filter = model.Filter ?? new FilterVM();


            return View(model);
        }

    }
}
