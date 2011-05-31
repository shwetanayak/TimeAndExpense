using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeAndExpense.Controllers
{
    [HandleError]
    public class AuthenticationController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}
