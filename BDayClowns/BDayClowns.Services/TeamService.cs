using BDayClowns.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDayClowns.Services
{
    public class TeamService
    {
        private TeamManager _manager;

        public TeamService(TeamManager manager)
        {
            _manager = manager;
        }
        public void TradePlayer()
        {
            _manager.TradePlayer();
        }
    }
}
