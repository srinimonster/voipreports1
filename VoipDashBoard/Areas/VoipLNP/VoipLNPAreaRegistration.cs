using System.Web.Mvc;

namespace VoipDashBoard.Areas.VoipLNP
{
    public class VoipLNPAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VoipLNP";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VoipLNP_default",
                "VoipLNP/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
