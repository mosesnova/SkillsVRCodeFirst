using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillsVRCodeFirst.Models;
using System.Diagnostics;

namespace SkillsVRCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private RugbyContext context;
      public HomeController(ILogger<HomeController> logger, RugbyContext cc)
        {
            _logger = logger;
            context = cc;
        }

        public IActionResult Index()
        {
            var pl = new Player {  Name = "YogiHosting", PlaceOfBirth = "XXYY", Height = "10", Weight = "10", DOB = "2014/06/24" };
             context.Entry(pl).State = EntityState.Added;
            context.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}