using Microsoft.AspNetCore.Mvc;

using AspNetCore_Template.Models;
using AspNetCore_Template.SystemModels;
using AspNetCore_Template.SystemServices;

namespace AspNetCore_Template.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
