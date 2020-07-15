using linxOne.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linxOne.WebApp.Controllers.Components
{
    public class PagerViewComponent:ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {


            return Task.FromResult((IViewComponentResult)View("Default", result));

        }
    }
}
