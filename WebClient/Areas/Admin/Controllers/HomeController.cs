﻿using Microsoft.AspNetCore.Mvc;

namespace WebClient.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // domain(Admin)/Admin/Home/Index
    }
}
