using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Namain_Hub_catalogue.Models;
using System.Diagnostics;

namespace Namain_Hub_catalogue.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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


    [Route("api/[controller]")]
    [ApiController]
    public class MyModelsController : ControllerBase
    {
        private readonly MyDbContext _context;

        public MyModelsController(MyDbContext context)
        {
            _context = context;
        }

        // Actions that use _context to interact with the database
    }
}