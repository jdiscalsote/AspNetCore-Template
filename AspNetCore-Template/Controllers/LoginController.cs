using Microsoft.AspNetCore.Mvc;

using AspNetCore_Template.Models;
using AspNetCore_Template.SystemModels;
using AspNetCore_Template.SystemServices;

namespace AspNetCore_Template.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Validate([FromForm] LoginModel collection)
        {
            try
            {
                string userNam = collection.Username;
                string userPass = collection.Password;
                if (ModelState.IsValid)
                {
                    if (userNam == "" || userNam == null)
                    {
                        ViewBag.Alert = AlertServices.ShowAlert(Alerts.Warning, "Please input your username");                        
                    }
                    else if (userPass == "" || userPass == null)
                    {
                        ViewBag.Alert = AlertServices.ShowAlert(Alerts.Warning, "Please input your password");
                    }
                    else if (userNam != "sysadmin" && userPass != "sysadmin")
                    {
                        ViewBag.Alert = AlertServices.ShowAlert(Alerts.Danger, "Incorrect username/password, please try again");
                        ModelState.Clear();
                    }
                    else
                    {
                        Response.Redirect("/Dashboard/Dashboard");
                    }
                }
                return PartialView("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
