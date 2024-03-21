using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace JobMatchingWebMVC.Controllers
{
    public class UserController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllUser(string name, int numTimes = 1)
        {
            ViewData["name"] = name;
            ViewData["number"] = numTimes;
            return View();
        }
    }
}
