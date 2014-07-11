#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFL.Web.Controllers
{

#if !DEBUG
      [RequireHttps]  
#endif
    public class MFLBaseController : Controller
    {        
	}
}