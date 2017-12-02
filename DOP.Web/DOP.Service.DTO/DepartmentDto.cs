using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DOP.Service.DTO
{
    [DataContract]
    public class DepartmentDto
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Adress { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Details { get; set; }
        [DataMember]
        public int DepartmentId { get; set; }
    }
}
