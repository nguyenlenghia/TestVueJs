using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMvcWithVue.AppMain.Controllers
{
    public class RestApiController : Controller
    {
        // GET: RestApi
        public ActionResult Index()
        {
            return View();
        }
    }
}