using System.Web;
using System.Web.Mvc;

namespace TestMvcWithVue.AppMain
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
