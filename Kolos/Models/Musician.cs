using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Models
{
    [Table("Musician")]
    public class Musician
    {
        [Key]
        public int IdMusician { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string? Nickname { get; set; }
    }
}
