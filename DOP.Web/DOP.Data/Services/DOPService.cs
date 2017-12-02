using DOP.Common.Models;
using DOP.Data.Bussines;
using DOP.Data.Clients;
using System.Collections.Generic;

namespace DOP.Data.Services
{
    public class DOPService:IDOPService
    {
        private IConvert convert;
        private IDOPClient client;

        public DOPService(IConvert convert, IDOPClient client)
        {
            this.client = client;
            this.convert = convert;
        }

        public List<Department> GetAllDepartments()
        {
            return convert.ToDepartmentList(client.GetAllDepartments());
        }

        public List<Personnel> GetAllPersonnel()
        {
            return convert.ToPersonelList(client.GetAllPersonnel());
        }

        public List<Personnel> GetPersonnelByDepartmentId(int id)
        {
            return convert.ToPersonelList(client.GetPersonnelByDepartmentId(id));
        }

        public Department GetDepartmentByPersonnelId(int id)
        {
            return convert.ToDepartment(client.GetDepartmentByPersonnelId(id));
        }

        public Department GetDepartmentById(int id)
        {
            return convert.ToDepartment(client.GetDepartmentById(id));
        }

        public Personnel GetPersonnelById(int id)
        {
            return convert.ToPersonnel(client.GetPersonnelById(id));
        }
    }
}
