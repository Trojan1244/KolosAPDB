
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
		private readonly OrganisationContext _dbContext;
		public DbService(OrganisationContext dbContext)
		{
			_dbContext = dbContext;
		}

        public async Task<SomeTeam> GetTeam(int id)
        {
			Team team = await _dbContext.Teams
				.Where(e => e.TeamID == id)
				.FirstOrDefaultAsync();

			Organization org = await _dbContext.Organizations
				.Where(o => o.OrganizationID == team.OrganizationID)
				.FirstOrDefaultAsync();
        }
    }
}

