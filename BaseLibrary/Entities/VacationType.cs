using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class VacationType : BaseEntity
    {
        //Many to one with Vacation
        [JsonIgnore]
        public List<Vacation>? Vacations { get; set; }
    }
}
