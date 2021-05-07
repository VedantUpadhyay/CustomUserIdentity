using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserIdentity.Models;
using System.IO;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace UserIdentity.Controllers
{
    [Area("NormalUser")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Console.WriteLine(_userManager.GetUserAsync(User).Result.NameUSER);
            return View();
        }

        [HttpPost]
        public IActionResult FormPost()
        {
            var filePath = @"D:\.NET projects\UserIdentity\wwwroot\UploadedImg.jpg";
            FileStream fs;
            try
            {
                IFormFile formFile = Request.Form.Files[0];
                fs = new FileStream(filePath, FileMode.Create);
                formFile.CopyTo(fs);
                fs.Close();

                return Json(new
                {
                    success = true
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    success = false,
                    errorMessage = ex.Message
                });
            }
            
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
