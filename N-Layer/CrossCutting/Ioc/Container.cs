using Application.Interfaces;
using Persistence;

namespace CrossCutting.Ioc
{
    public static class Container
    {
        public static SimpleInjector.Container RegisterServices()
        {
            var container = new SimpleInjector.Container();

            container.Register<IDatabaseService, DatabaseService>();

            container.Verify();

            return container;
        }
    }
}
