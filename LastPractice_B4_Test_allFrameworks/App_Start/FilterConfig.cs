using System.Web;
using System.Web.Mvc;

namespace LastPractice_B4_Test_allFrameworks
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
