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
        protected override IAsyncResult BeginExecute(System.Web.Routing.RequestContext requestContext, AsyncCallback callback, object state)
        {
#if !DEBUG
            if(!HttpContext.Request.IsSecureConnection)
            {
                Response.Redirect(Request.Url.AbsoluteUri.Replace("http://", "https://"), true);                
            }
            else
            {
                base.BeginExecute(requestContext, callback, state);
            }
#else
            return base.BeginExecute(requestContext, callback, state);
#endif
        }
	}
}