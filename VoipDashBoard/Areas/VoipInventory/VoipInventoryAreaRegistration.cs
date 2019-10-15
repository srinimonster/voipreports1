using System.Web.Mvc;

namespace VoipDashBoard.Areas.VoipInventory
{
    public class VoipInventoryAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VoipInventory";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VoipInventory_default",
                "VoipInventory/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
