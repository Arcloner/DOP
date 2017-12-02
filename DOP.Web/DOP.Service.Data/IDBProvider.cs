using DOP.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOP.Service.Data
{
    public interface IDBProvider
    {
        List<PersonnelDto> GetAllPersonnel();
        List<PersonnelDto> GetPersonnelByDepartmentId(int id);
        PersonnelDto GetPersonnelById(int id);

        List<DepartmentDto> GetAllDepartments();
        DepartmentDto GetDepartmentByPersonnelId(int id);
        DepartmentDto GetDepartmentById(int id);
    }
}
