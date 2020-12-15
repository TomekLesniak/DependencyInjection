using System;
using Autofac;
using Autofac.Core;

namespace DependecyInjcetionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfigurator.Configure();

            using var scope = container.BeginLifetimeScope();
            var application = scope.Resolve<IApplication>();

            application.Run();
        }
    }
}
