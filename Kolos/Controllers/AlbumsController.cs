using Kolos.Models.DTO;
using Kolos.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public AlbumsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<IActionResult> DeleteClient(int idAlbum)
        {
            try
            {
                SomeAlbum someAlbum = await _dbService.GetAlbumInfo(idAlbum);
                return Ok(someAlbum);
            }
            catch (ArgumentException)
            {
                return Conflict();
            }   
        }
    }
}
