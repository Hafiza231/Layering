using codefirstlayering.BL;
using codefirstlayeringEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codefirstlayering.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MyFIrstTableBL bl = new MyFIrstTableBL();

            List<MyFirstTable> list =bl.GetAllDataBL();
            

            return View(list);
        }
    }
}