using CrossCutting.Ioc;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Api.App_Start.IocInitializer), "Start")]
namespace Api.App_Start
{
    public class IocInitializer
    {
        public static void Start() {

            var container = Container.RegisterServices();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}