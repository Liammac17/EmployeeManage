using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Country : BaseEntity
    {
        //one to many with City

        public List<City>? Citites { get; set; }
    }
}
