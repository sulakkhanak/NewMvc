using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvc_Test.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowPerson()
        {
            return View();
        }

        public ActionResult ShowDepartment()
        {
            return View();
        }

	}
}