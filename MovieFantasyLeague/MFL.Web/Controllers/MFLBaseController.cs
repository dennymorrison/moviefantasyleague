#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFL.Web.Controllers
{
    public class MFLBaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {            
#if (!DEBUG)
            if(!HttpContext.Request.IsSecureConnection)
            {
                Response.Redirect(Request.Url.AbsoluteUri.ToLower().Replace("http://", "https://"), true);                
            }
            else
            {
                base.OnActionExecuting(filterContext);
            }
#else
            base.OnActionExecuting(filterContext);
#endif            
        }
	}
}