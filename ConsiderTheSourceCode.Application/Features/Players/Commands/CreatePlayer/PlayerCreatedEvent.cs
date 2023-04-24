using ConsiderTheSourceCode.Domain.Common;
using ConsiderTheSourceCode.Domain.Entities;

namespace ConsiderTheSourceCode.Application.Features.Players.Commands.CreatePlayer
{
    public class PlayerCreatedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerCreatedEvent(Player player)
        {
            Player = player;
        }
    }
}
