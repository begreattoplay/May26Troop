using MovieStore.Domain.Models;
using MovieStore.Infrastructure.Persistence.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Services
{
    public class ServicesDependencies : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<GenericRepository>();
        }
    }
}
