using System.Web;
using System.Web.Mvc;

namespace Student_Batch_Mangement_System_ServerSide
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
