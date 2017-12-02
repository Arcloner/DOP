using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOP.Common.Models
{
    public class Personnel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Adress { get; set; }
        public bool FamilyState { get; set; }
        public string Photo { get; set; }
        public int PersonnelId { get; set; }
        public int DepartmentId { get; set; }
        public int ContactId { get; set; }
    }
}
