using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Models
{
    [Table("MusicLabel")]
    public class MusicLabel
    {
        [Key]
        public int IdMusicLabel { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
