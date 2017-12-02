using DOP.Common.Models;
using System.Collections.Generic;

namespace DOP.Bussines.Providers
{
    public interface IDOPProvider
    {
        List<Personnel> GetAllPersonnel();
        List<Personnel> GetPersonnelByDepartmentId(int id);
        List<Department> GetAllDepartments();
        Department GetDepartmentByPersonnelId(int id);
        Department GetDepartmentById(int id);
        Personnel GetPersonnelById(int id);
    }
}
