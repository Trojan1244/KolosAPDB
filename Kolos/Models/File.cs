using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos.Models
{
    [Table("File")]
    public class File
    {
        [Key]
        public int FileID { get; set; }
        [ForeignKey("Team")]
        public int TeamID { get; set; }
        public Team Team { get; set; }
        [MaxLength(100)]
        public string FileName { get; set; }
        [MaxLength(4)]
        public string FileExtension { get; set; }
        [Column]
        public int FileSize { get; set; }
    }
}
