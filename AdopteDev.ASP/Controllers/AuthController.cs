﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteDev.ASP.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult TypeRegister()
        {
            return View();
        }
    }
}
