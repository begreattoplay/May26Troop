using System.Web;
using System.Web.Mvc;

namespace Day7Lab1StronglyTyped
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
