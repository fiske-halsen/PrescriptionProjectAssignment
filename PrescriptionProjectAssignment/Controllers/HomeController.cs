using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrescriptionProjectAssignment.Services;
using PrescriptionProjectAssignment.ViewModels;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmailService _emailService;
        private readonly TimerService _timerService;

        public HomeController(ILogger<HomeController> logger, EmailService emailService, TimerService timerService)
        {
            _logger = logger;
            _emailService = emailService;
            _timerService = timerService;
        }

        public async Task<IActionResult> Index()
        {
            //await _timerService.Timer();
            return View();
        }

        public async Task<IActionResult> PrivacyAsync()
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
