using System.Collections.Generic;

namespace Kolos.Models.DTO
{
    public class SomeTeam
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Organisation { get; set; }
        public IEnumerable<SomeMember> Members { get; set; }
    }
}
