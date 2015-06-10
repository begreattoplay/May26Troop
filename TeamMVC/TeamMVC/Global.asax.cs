using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TeamMVC.Data.Models;
using TeamMVC.Models;

namespace TeamMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Mapper.CreateMap<Player, PlayerViewModel>()
                .ForMember(d => d.PlayerName, m => m.MapFrom(s => s.FirstName + " " + s.LastName));
        }
    }

    //public class CustomResolver : ValueResolver<Player, string>
    //{
    //    protected override string ResolveCore(Player source)
    //    {
    //        return source.FirstName + " " + source.LastName;
    //    }
    //}
}
