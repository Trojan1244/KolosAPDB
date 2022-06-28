using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Models
{
    [Table("Track")]
    public class Track
    {
        [Key]
        public int IdTrack { get; set; }
        [MaxLength(20)]
        public string TrackName { get; set; }
        public float Duration { get; set; }
        [ForeignKey("Album")]
        public int? IdAlbum { get; set; }
    }
}
