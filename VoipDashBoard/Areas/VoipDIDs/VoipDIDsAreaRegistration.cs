using System.Web.Mvc;

namespace VoipDashBoard.Areas.VoipDIDs
{
    public class VoipDIDsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VoipDIDs";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VoipDIDs_default",
                "VoipDIDs/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
