using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogViewComponent.ViewComponents
{
    [ViewComponent]
    public class NamingConvention3 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
