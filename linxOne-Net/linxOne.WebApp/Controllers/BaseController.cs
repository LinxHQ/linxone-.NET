using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace linxOne.WebApp.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var sessions = context.HttpContext.Session.GetString("Token");
            if (sessions==null)
            {
                context.Result = new RedirectToActionResult("Index", "Account", null);

            }
            base.OnActionExecuting(context);
        }
    }
}