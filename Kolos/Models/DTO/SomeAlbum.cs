using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Models.DTO
{
    public class SomeAlbum
    {
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        public string MusicLabel { get; set; }
        public IEnumerable<Track> Tracks { get; set; }
    }
}
