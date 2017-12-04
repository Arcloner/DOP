using DOP.Bussines.Providers;
using DOP.Bussines.Search;
using System.Web.Mvc;

namespace DOP.Web.Controllers
{
    public class SearchController : Controller
    {
        private IDOPProvider provider;
        private IDOPSearch searcher;    
        public SearchController(IDOPProvider provider,IDOPSearch searcher)
        {
            this.provider = provider;
            this.searcher = searcher;
        }
        public ActionResult SearchPage()
        {            
            return View();
        }
        public ActionResult SearchPersonnelByLNM(string LNM)
        {
            return PartialView("~/Views/PartialViews/PersonnelPartialView.cshtml", searcher.SearchPersonnels(LNM, provider.GetAllPersonnel()));
        }
    }
}