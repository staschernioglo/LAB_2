using MusicInShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicInShop.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        InstrumentContext db = new InstrumentContext();
        public ActionResult Index()
        {
            return View(db.Instruments);
        }
    }
}