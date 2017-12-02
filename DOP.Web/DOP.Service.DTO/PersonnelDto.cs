using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DOP.Service.DTO
{
    [DataContract]
    public class PersonnelDto
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string Adress { get; set; }
        [DataMember]
        public bool FamilyState { get; set; }
        [DataMember]
        public string Photo { get; set; }
        [DataMember]
        public int PersonnelId { get; set; }
        [DataMember]
        public int DepartmentId { get; set; }
        [DataMember]
        public int ContactId { get; set; }
    }
}
