using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogViewComponent.ViewComponents
{
    public class NamingConvention5 : NamingConventionAbstract
    {
        public override IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
