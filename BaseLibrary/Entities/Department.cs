using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Department : BaseEntity
    {
        //One to many relationship with Department
        public GeneralDepartment? GeneralDepartment { get; set; }

        public int GeneralDepartmentId { get; set; }

        //one to many with Branch
        public List<Branch>? Branches { get; set; }
    }
}
