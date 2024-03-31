using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using System.Diagnostics;

namespace Resume.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ILogger<ResumeController> _logger;

        public ResumeController(ILogger<ResumeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SoftwareDevelopment()
        {
            return View();
        }

        public IActionResult SystemAdministration()
        {
            return View();
        }

        public IActionResult ComputerNetworking()
        {
            return View();
        }

        public IActionResult Startpage()
        {
            return Redirect("https://stegeman.dev");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
