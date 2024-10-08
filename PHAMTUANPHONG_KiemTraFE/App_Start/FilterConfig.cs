using System.Web;
using System.Web.Mvc;

namespace PHAMTUANPHONG_KiemTraFE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
