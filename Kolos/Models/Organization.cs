using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos.Models
{
    [Table("Organization")]
    public class Organization
    {
        [Key]
        public int OrganizationID { get; set; }
        [MaxLength(100)]
        public string OrganizationName { get; set; }
        [MaxLength(50)]
        public string OrganizationDomain { get; set; }
    }
}
