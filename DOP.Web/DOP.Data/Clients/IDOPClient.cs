using DOP.Data.DOPService;
using System.Collections.Generic;

namespace DOP.Data.Clients
{
    public interface IDOPClient
    {
        List<PersonnelDto> GetAllPersonnel();
        List<DepartmentDto> GetAllDepartments();
        List<PersonnelDto> GetPersonnelByDepartmentId(int id);
        DepartmentDto GetDepartmentByPersonnelId(int id);
        DepartmentDto GetDepartmentById(int id);
        PersonnelDto GetPersonnelById(int id);
    }
}
