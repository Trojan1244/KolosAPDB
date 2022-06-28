using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Models
{
    [Table("Musician_Track")]
    public class MusicianTrack
    {
        [ForeignKey("Track")]
        public int IdTrack { get; set; }
        [ForeignKey("Musician")]
        public int IdMusician { get; set; }
    }
}
