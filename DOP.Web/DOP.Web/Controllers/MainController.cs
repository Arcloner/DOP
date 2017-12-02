using DOP.Bussines.Providers;
using DOP.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOP.Web.Controllers
{
    public class MainController : Controller
    {
        private IDOPProvider provider;
        public MainController(IDOPProvider provider)
        {
            this.provider = provider;
        }
        // GET: Main
        public ActionResult Index()
        {
            List<Department> dps = provider.GetAllDepartments();
            return View();
        }
    }
}