using DOP.Service.Data;
using DOP.Service.DTO;
using System.Collections.Generic;

namespace DOP.Service.Contracts
{
    public class PersonnelDepartmentService : IPersonnelDepartmentService
    {
        public IDBProvider DbProvider;
        public PersonnelDepartmentService()
        {
            DbProvider = new DBProvider();
        }
        public List<DepartmentDto> GetAllDepartments()
        {
            return DbProvider.GetAllDepartments();
        }

        public List<PersonnelDto> GetAllPersonnel()
        {
            return DbProvider.GetAllPersonnel();
        }

        public DepartmentDto GetDepartmentById(int id)
        {
            return DbProvider.GetDepartmentById(id);
        }

        public DepartmentDto GetDepartmentByPersonnelId(int id)
        {
            return DbProvider.GetDepartmentByPersonnelId(id);
        }

        public List<PersonnelDto> GetPersonnelByDepartmentId(int id)
        {
            return DbProvider.GetPersonnelByDepartmentId(id);
        }

        public PersonnelDto GetPersonnelById(int id)
        {
            return DbProvider.GetPersonnelById(id);
        }
    }
}
