﻿using Microsoft.AspNetCore.Mvc;

namespace MVCLibros.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}