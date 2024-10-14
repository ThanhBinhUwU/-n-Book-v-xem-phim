using System.Web;
using System.Web.Mvc;

namespace Đồ_án_Book_vé_xem_phim
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
