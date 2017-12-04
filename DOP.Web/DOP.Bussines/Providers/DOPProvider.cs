using DOP.Bussines.Search;
using DOP.Common.Models;
using DOP.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOP.Bussines.Providers
{
    public class DOPProvider : IDOPProvider
    {
        private IDOPService service;        

        public DOPProvider(IDOPService service)
        {
            this.service = service;            
        }
        public List<Department> GetAllDepartments()
        {
            return service.GetAllDepartments();
        }

        public List<Personnel> GetAllPersonnel()
        {
            return service.GetAllPersonnel();
        }

        public Department GetDepartmentById(int id)
        {
            return service.GetDepartmentById(id);
        }

        public Department GetDepartmentByPersonnelId(int id)
        {
            return service.GetDepartmentByPersonnelId(id);
        }

        public List<Personnel> GetPersonnelByDepartmentId(int id)
        {
            return service.GetPersonnelByDepartmentId(id);
        }

        public Personnel GetPersonnelById(int id)
        {
            return service.GetPersonnelById(id);
        }
       
    }
}
