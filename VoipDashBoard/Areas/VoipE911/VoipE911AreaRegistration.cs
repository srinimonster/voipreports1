using System.Web.Mvc;

namespace VoipDashBoard.Areas.VoipE911
{
    public class VoipE911AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VoipE911";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VoipE911_default",
                "VoipE911/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
