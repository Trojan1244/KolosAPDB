using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos.Models
{
    [Table("Membership")]
    public class Membership
    {
        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public Member Member { get; set; }
        [ForeignKey("Team")]
        public int TeamID { get; set; }
        public Team Team { get; set; }
        [Required]
        public DateTime MembershipDate { get; set; }
    }
}
