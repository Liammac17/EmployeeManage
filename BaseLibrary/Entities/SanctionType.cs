using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class SanctionType : BaseEntity
    {
        //Many to one with Vacation
        [JsonIgnore]
        public List<Sanction>? Sanctions { get; set; }
    }
}
