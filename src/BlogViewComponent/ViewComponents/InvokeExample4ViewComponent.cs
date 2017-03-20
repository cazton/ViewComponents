using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogViewComponent.ViewComponents
{
    public class InvokeExample4ViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id, bool isNew)
        {
            return isNew ? View("WithParametersLatest") : View("WithParameters");
        }
    }
}
