using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Models
{
    [Table("Album")]
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        [MaxLength(30)]
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        [ForeignKey("MusicLabel")]
        public int IdMusicLabel { get; set; }
    }
}
