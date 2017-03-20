using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogViewComponent.ViewComponents
{
    public abstract class NamingConventionAbstract : ViewComponent
    {
        public abstract IViewComponentResult Invoke();
    }
}
