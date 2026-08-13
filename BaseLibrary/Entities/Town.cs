using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Town : BaseEntity
    {
        //one to many with Employee

        public List<Employee>? Employees { get; set; }
        //many to one with city

        public City? City { get; set; }
        public int CityId { get; set; } 
    }
}
