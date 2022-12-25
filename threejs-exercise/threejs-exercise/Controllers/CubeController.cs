﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using threejs_exercise.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace threejs_exercise.Controllers
{
    public class CubeController : Controller
    {
        public IActionResult xIncr()
        { 
            Cube cube = ViewBag.Message;
            cube.x = cube.x + 0.1;

            ViewBag.Message = cube;
            return View("Index");
        }
    }
}
