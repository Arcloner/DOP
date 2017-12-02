using DOP.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOP.Data.Services
{
    public interface IDOPService
    {
        List<Personnel> GetAllPersonnel();
        List<Personnel> GetPersonnelByDepartmentId(int id);
        List<Department> GetAllDepartments();
        Department GetDepartmentByPersonnelId(int id);
        Department GetDepartmentById(int id);
        Personnel GetPersonnelById(int id);
    }
}
