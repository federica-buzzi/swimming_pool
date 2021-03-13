using System.Web.Mvc;

namespace ASP_petit_bassin.Areas.Administrateur
{
    public class AdministrateurAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Administrateur";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Administrateur_default",
                "Administrateur/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}