using System.Web.Http;
using WebActivatorEx;
using Book.Store.WebApi;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Book.Store.WebApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Book.Store.WebApi");
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }

        public static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\bin\Book.Store.WebApi.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}