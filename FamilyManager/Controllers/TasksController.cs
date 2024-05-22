using FamilyManager.ActionFilters;
using FamilyManager.Repositories;
using FamilyManager.ViewModels.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace FamilyManager.Controllers
{
    [AuthenticationFilter]
    public class TasksController : Controller
    {
        [HttpGet]
        public IActionResult Index(IndexVM model)
        {

            return View(model);
        }

    }
}
