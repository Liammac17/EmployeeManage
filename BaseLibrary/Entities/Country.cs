using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Country : BaseEntity
    {
        //one to many with City
        [JsonIgnore]
        public List<City>? Citites { get; set; }
    }
}
