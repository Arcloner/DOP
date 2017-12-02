using DOP.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DOP.Service.Contracts
{
    [ServiceContract]
    public interface IPersonnelDepartmentService
    {
        [OperationContract]
        List<PersonnelDto> GetAllPersonnel();
        [OperationContract]
        List<PersonnelDto> GetPersonnelByDepartmentId(int id);
        [OperationContract]
        PersonnelDto GetPersonnelById(int id);


        [OperationContract]
        List<DepartmentDto> GetAllDepartments();
        [OperationContract]
        DepartmentDto GetDepartmentByPersonnelId(int id);
        [OperationContract]
        DepartmentDto GetDepartmentById(int id);
    }
}
