using DOP.Bussines.Providers;
using DOP.Bussines.Search;
using DOP.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOP.Web.Controllers
{
    public class SearchController : Controller
    {
        private IDOPProvider provider;        
        public SearchController(IDOPProvider provider)
        {
            this.provider = provider;            
        }
        public ActionResult SearchPage()
        {
            ISearchable searcher = new LevenshteinSearch();
            List<Personnel> Test = searcher.SearchPersonnels("LezebokinIvanIvanov", provider.GetAllPersonnel());
            return View();
        }
        public ActionResult SearchPersonnelByLNM(string LNM)
        {
            ISearchable searcher = new LevenshteinSearch();
            List<Personnel> Test = searcher.SearchPersonnels(LNM, provider.GetAllPersonnel());
            return PartialView("~/Views/PartialViews/PersonnelPartialView.cshtml", searcher.SearchPersonnels(LNM, provider.GetAllPersonnel()));
        }
    }
}