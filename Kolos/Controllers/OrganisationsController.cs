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
    public class OrganisationsController : ControllerBase
    {
        private readonly IDbService _dbService;

        [HttpGet]
        public async Task<IActionResult> GetTeam(int teamID)
        {
            return _dbService.GetTeam(teamID);
        }
    }
}
