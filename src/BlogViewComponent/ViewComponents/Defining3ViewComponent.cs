﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogViewComponent.ViewComponents
{
    public class Defining3ViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AnotherView");
        }
    }
}
