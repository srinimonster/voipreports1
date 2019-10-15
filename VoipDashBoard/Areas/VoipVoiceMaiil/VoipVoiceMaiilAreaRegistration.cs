using System.Web.Mvc;

namespace VoipDashBoard.Areas.VoipVoiceMaiil
{
    public class VoipVoiceMaiilAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VoipVoiceMaiil";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VoipVoiceMaiil_default",
                "VoipVoiceMaiil/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
