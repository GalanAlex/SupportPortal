using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SupportPortal.Models;

namespace SupportPortal.Controllers
{
    public class ChatController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ChatController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("/chat")]
        public IActionResult Index()
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
