using Application.Interfaces;
using Application.Movies.Commands;
using Application.Movies.Queries;
using Persistence;
using SimpleInjector.Lifestyles;

namespace CrossCutting.Ioc
{
    public static class Container
    {
        public static SimpleInjector.Container RegisterServices()
        {
            var container = new SimpleInjector.Container();

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IDatabaseService, DatabaseService>(SimpleInjector.Lifestyle.Scoped);
            container.Register<IGetMoviesListQuery, GetMoviesListQuery>(SimpleInjector.Lifestyle.Scoped);
            container.Register<IAddMovieCommand, AddMovieCommand>(SimpleInjector.Lifestyle.Scoped);

            container.Verify();
                        
            return container;
        }

    }
}
