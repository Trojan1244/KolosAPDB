
using Kolos.Models;
using Kolos.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos.Services
{
	public class DbService : IDbService
	{
		private readonly KolosContext _dbContext;
		public DbService(KolosContext dbContext)
		{
			_dbContext = dbContext;
		}

        public async Task<SomeAlbum> GetAlbumInfo(int idAlbum)
        {
			Album album = _dbContext.Albums.Where(e => e.IdAlbum == idAlbum).FirstOrDefault();
			List<Track> tracks = await _dbContext.Tracks.Where(e => e.IdAlbum == idAlbum).ToListAsync();

			string musicLabelName = "None";
			if(album.IdMusicLabel != null)
            {
				musicLabelName = _dbContext.MusicLabels.Where(e => e.IdMusicLabel == album.IdMusicLabel).FirstOrDefault().Name;
			}

			SomeAlbum someAlbum = new SomeAlbum {
				IdAlbum = album.IdAlbum,
				AlbumName = album.AlbumName,
				PublishDate = album.PublishDate,
				MusicLabel = musicLabelName,
				Tracks = tracks
			};

			return someAlbum;
		}
    }
}

