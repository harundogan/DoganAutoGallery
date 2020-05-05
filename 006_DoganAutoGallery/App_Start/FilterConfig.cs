using System.Web;
using System.Web.Mvc;

namespace _006_DoganAutoGallery
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
