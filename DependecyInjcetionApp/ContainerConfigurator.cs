using Autofac;
using DependencyInjcetionLibrary;

namespace DependecyInjcetionApp
{
    public static class ContainerConfigurator
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<Phone>().As<IPhone>();
            builder.RegisterType<SmsService>().As<IMessageService>();
            builder.RegisterType<Calculator>().As<ICalculator>();

            return builder.Build();
        }
    }
}