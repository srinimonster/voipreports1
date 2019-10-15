using System.Web.Mvc;

namespace VoipDashBoard.Areas.VoipTickets
{
    public class VoipTicketsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VoipTickets";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VoipTickets_default",
                "VoipTickets/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
