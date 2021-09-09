using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroToWeb.Models;

namespace IntroToWeb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Submit");
            }
            return View(model);
        }
        public ActionResult Submit(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }else
            {
                return RedirectToAction("Index");
            }
        }
    }
}