using Autofac;
using GamifyApp.Domain.Services;

namespace GamifyApp.Domain
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //TODO: Make this easier
            builder.RegisterType<HelloService>().AsImplementedInterfaces().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
