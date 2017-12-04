using DOP.Bussines.Providers;
using DOP.Common.Models;
using DOP.Web.ViewModels;
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
        
        public ActionResult StartPage(int? id)
        {
            if (id != null)
            {
                ViewBag.SelectedId = id;
                return View(new StartPageViewModel()
                {
                    Departments = provider.GetAllDepartments(),
                    Personnel = provider.GetPersonnelByDepartmentId((int)id),                    
                });
            }
            else
            {
                ViewBag.SelectedId = id;
                return View(new StartPageViewModel()
                {
                    Departments = provider.GetAllDepartments(),
                    Personnel = provider.GetAllPersonnel(),                    
                });
            }
        }
        public ActionResult PersonnelDetails(int PersonnelId)
        {            
            return View(provider.GetPersonnelById(PersonnelId));
        }
    }
}