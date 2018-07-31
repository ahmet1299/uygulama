using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uygulama.Models;

namespace uygulama.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            List<sinif> sinif_list = new List<sinif>()
            {
                new sinif {Id=1,username="ferhat" },
                new sinif {Id=2, username="ahmet"}
            };

            return View(sinif_list);
        }
    }
}