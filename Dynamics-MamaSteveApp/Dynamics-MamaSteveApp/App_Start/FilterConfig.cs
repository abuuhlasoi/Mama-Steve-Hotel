using System.Web;
using System.Web.Mvc;

namespace Dynamics_MamaSteveApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
