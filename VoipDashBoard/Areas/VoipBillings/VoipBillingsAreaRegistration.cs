using System.Web.Mvc;

namespace VoipDashBoard.Areas.VoipBillings
{
    public class VoipBillingsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VoipBillings";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VoipBillings_default",
                "VoipBillings/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
