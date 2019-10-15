using System.Web.Mvc;

namespace VoipDashBoard.Areas.ViopRecordings
{
    public class ViopRecordingsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ViopRecordings";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ViopRecordings_default",
                "ViopRecordings/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
