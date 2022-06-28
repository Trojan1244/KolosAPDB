using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }
        public Organization Organization { get; set; }
        [InverseProperty("Team")]
        public ICollection<Membership> Memberships { get; set; }
        [MaxLength(50)]
        public string TeamName { get; set; }
        [MaxLength(500)]
        public string? TeamDescription { get; set; }
    }
}
