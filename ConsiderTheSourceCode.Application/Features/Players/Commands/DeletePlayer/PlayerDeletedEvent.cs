using ConsiderTheSourceCode.Domain.Common;
using ConsiderTheSourceCode.Domain.Entities;

namespace ConsiderTheSourceCode.Application.Features.Players.Commands.DeletePlayer
{
    public class PlayerDeletedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerDeletedEvent(Player player)
        {
            Player = player;
        }
    }
}
