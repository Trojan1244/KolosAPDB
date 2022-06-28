using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos.Models
{
    [Table("Member")]
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }
        public Organization Organization { get; set; }
        [MaxLength(20)]
        public string MemberName { get; set; }
        [MaxLength(50)]
        public string MemberSurname { get; set; }
        [MaxLength(20)]
        public string? MemberNickName { get; set; }
    }
}
