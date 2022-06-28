using Kolos.Models;
using Kolos.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Kolos.Services
{
    public interface IDbService
    {
        Task<SomeTeam> GetTeam(int id);
    }
}
