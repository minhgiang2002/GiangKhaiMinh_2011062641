using System.Web;
using System.Web.Mvc;

namespace GiangKhaiMinh_2011062641
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
