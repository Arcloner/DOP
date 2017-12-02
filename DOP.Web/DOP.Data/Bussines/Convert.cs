using DOP.Common.Models;
using DOP.Data.DOPService;
using System.Collections.Generic;

namespace DOP.Data.Bussines
{
    public class Convert : IConvert
    {
        public Department ToDepartment(DepartmentDto department)
        {
            return new Department() { Name = department.Name, Adress = department.Adress, DepartmentId = department.DepartmentId, Details = department.Details, PhoneNumber = department.PhoneNumber };
        }

        public List<Department> ToDepartmentList(List<DepartmentDto> departments)
        {
            List<Department> result = new List<Department>();
            foreach (var item in departments)
            {
                result.Add(new Department { Name = item.Name, Adress = item.Adress, Details = item.Details, PhoneNumber = item.PhoneNumber, DepartmentId = item.DepartmentId });
            }
            return result;
        }

        public List<Personnel> ToPersonelList(List<PersonnelDto> personnel)
        {
            List<Personnel> result = new List<Personnel>();
            foreach (var item in personnel)
            {
                result.Add(new Personnel { Name = item.Name, LastName = item.LastName, FamilyState = item.FamilyState, DepartmentId = item.DepartmentId, Adress = item.Adress, ContactId = item.ContactId, MiddleName = item.MiddleName, PersonnelId = item.PersonnelId, Photo = item.Photo });
            }
            return result;
        }

        public Personnel ToPersonnel(PersonnelDto personnel)
        {
            return new Personnel() { Adress = personnel.Adress, FamilyState = personnel.FamilyState, ContactId = personnel.ContactId, DepartmentId = personnel.DepartmentId, LastName = personnel.LastName, MiddleName = personnel.MiddleName, Name = personnel.Name, PersonnelId = personnel.PersonnelId, Photo = personnel.Photo };
        }
    }
}
