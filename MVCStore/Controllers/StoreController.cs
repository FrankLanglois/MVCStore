using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStore.Controllers
{
    [Authorize]
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public string Store( string name)
        {
            return HttpUtility.HtmlEncode( $"Hello {name}!");
        }
    }
}