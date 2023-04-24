using ConsiderTheSourceCode.Domain.Entities;

namespace ConsiderTheSourceCode.Application.Interfaces.Repositories
{
    public interface IPlayerRepository
    {
        Task<List<Player>> GetPlayersByClubAsync(int clubId);
    }
}
