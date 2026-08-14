using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Branch : BaseEntity
    {
        //Many to one with Department
        public Department? Department { get; set; }
        public int DepartmentId { get; set; }

        //one to many with Employee
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
