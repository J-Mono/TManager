using System.Web;
using System.Web.Mvc;

namespace PROG6212_Poe_Joseph_20104412
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
