using System.Web.Mvc;

namespace VoipDashBoard.Areas.VoipSMSReports
{
    public class VoipSMSReportsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VoipSMSReports";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VoipSMSReports_default",
                "VoipSMSReports/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
