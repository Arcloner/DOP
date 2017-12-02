using DOP.Data.DOPService;
using System.Collections.Generic;

namespace DOP.Data.Clients
{
    public class DOPClient : IDOPClient
    {
        public List<DepartmentDto> GetAllDepartments()
        {
            List<DepartmentDto> result;
            using (var service = new PersonnelDepartmentServiceClient())
            {
                service.Open();
                result = service.GetAllDepartments();
                service.Close();
            }
            return result;
        }

        public List<PersonnelDto> GetAllPersonnel()
        {
            var service = new PersonnelDepartmentServiceClient();
            service.Open();
            List<PersonnelDto> result = service.GetAllPersonnel();
            service.Close();
            return result;
        }

        public List<PersonnelDto> GetPersonnelByDepartmentId(int id)
        {
            var service = new PersonnelDepartmentServiceClient();
            service.Open();
            List<PersonnelDto> result = service.GetPersonnelByDepartmentId(id);
            service.Close();
            return result;
        }

        public DepartmentDto GetDepartmentByPersonnelId(int id)
        {
            var service = new PersonnelDepartmentServiceClient();
            service.Open();
            DepartmentDto result = service.GetDepartmentByPersonnelId(id);
            service.Close();
            return result;
        }

        public DepartmentDto GetDepartmentById(int id)
        {
            var service = new PersonnelDepartmentServiceClient();
            service.Open();
            DepartmentDto result = service.GetDepartmentById(id);
            service.Close();
            return result;
        }

        public PersonnelDto GetPersonnelById(int id)
        {
            var service = new PersonnelDepartmentServiceClient();
            service.Open();
            PersonnelDto result = service.GetPersonnelById(id);
            service.Close();
            return result;
        }
    }
}
