using System.Web.Mvc;

namespace VoipDashBoard.Areas.ViopReporting
{
    public class ViopReportingAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ViopReporting";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ViopReporting_default",
                "ViopReporting/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
