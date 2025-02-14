﻿using ConsiderTheSourceCode.Domain.Common;
using ConsiderTheSourceCode.Domain.Entities;

namespace ConsiderTheSourceCode.Application.Features.Players.Commands.UpdatePlayer
{
    public class PlayerUpdatedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerUpdatedEvent(Player player)
        {
            Player = player;
        }
    }
}
