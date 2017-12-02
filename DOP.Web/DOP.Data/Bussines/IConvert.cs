using DOP.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOP.Data.Bussines
{
    public interface IConvert
    {
        List<Department> ToDepartmentList(List<DOPService.DepartmentDto> departments);
        List<Personnel> ToPersonelList(List<DOPService.PersonnelDto> personnel);
        Department ToDepartment(DOPService.DepartmentDto department);
        Personnel ToPersonnel(DOPService.PersonnelDto personnel);
    }
}
