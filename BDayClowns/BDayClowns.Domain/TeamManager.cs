using BDayClowns.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDayClowns.Domain
{
    public class TeamManager
    {
        private Repository _repo;

        public TeamManager(Repository repo)
        {
            _repo = repo;
        }

        public void TradePlayer()
        {
            _repo.Find()

            _repo.SaveChanges();
        }
    }
}
