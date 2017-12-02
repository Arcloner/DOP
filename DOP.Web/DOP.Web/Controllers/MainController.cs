using DOP.Bussines.Providers;
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
                return View(new StartPageViewModel()
                {
                    Departments = provider.GetAllDepartments(),
                    Personnel = provider.GetPersonnelByDepartmentId((int)id),
                    SelectedDepartment = id
                });
            }
            else
            {
                return View(new StartPageViewModel()
                {
                    Departments = provider.GetAllDepartments(),
                    Personnel = provider.GetAllPersonnel(),
                    SelectedDepartment = id
                });
            }
        }
    }
}