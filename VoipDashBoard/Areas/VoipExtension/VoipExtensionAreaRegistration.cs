using System.Web.Mvc;

namespace VoipDashBoard.Areas.VoipExtension
{
    public class VoipExtensionAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VoipExtension";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VoipExtension_default",
                "VoipExtension/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
