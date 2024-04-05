using COMP003B.Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COMP003B.Assignment2.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
