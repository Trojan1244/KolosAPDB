using System;

namespace Kolos.Models.DTO
{
    public class SomeMember
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? MemberNickName { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
