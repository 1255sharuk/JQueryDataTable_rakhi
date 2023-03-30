using JQueryDataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryDataTable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxMethod()
        {
            NorthwindEntities entities = new NorthwindEntities();
            List<Customer> customers = (from customer in entities.Customers select customer).ToList();
            return Json(customers);
        }
    }
    }
