using System.Web.Mvc;

namespace Book.Store.MVC.Areas.Livros
{
    public class LivrosAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Livros";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Livros_default",
                "{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}