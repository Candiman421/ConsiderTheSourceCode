using ConsiderTheSourceCode.Application.Interfaces.Repositories;
using ConsiderTheSourceCode.Domain.Entities;
using ConsiderTheSourceCode.Persistence.Contexts;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsiderTheSourceCode.Persistence.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly IGenericRepository<Player> _repository;

        public PlayerRepository(IGenericRepository<Player> repository) 
        {
            _repository = repository;
        }

        public async Task<List<Player>> GetPlayersByClubAsync(int clubId)
        {
            return await _repository.Entities.Where(x => x.ClubId == clubId).ToListAsync();
        }
    }
}
