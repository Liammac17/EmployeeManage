using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class City : BaseEntity
    {
        //Many to one with Country

        public Country? Country { get; set; }
        public int CountryId { get; set; }

        //One to many with Town
        [JsonIgnore]
        public List<Town>? Towns { get; set; }
    }
}
