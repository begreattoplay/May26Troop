using System;
using System.Collections.Generic;
using TeamMVC.Models;
namespace TeamMVC.Repositories
{
    public interface IPlayerRepository
    {
        void CreatePlayer(CreatePlayerViewModel player);
        IList<PlayerViewModel> GetPlayers();
    }
}
