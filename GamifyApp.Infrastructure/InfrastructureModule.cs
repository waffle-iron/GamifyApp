using Autofac;
using GamifyApp.Infrastructure.Repositories;

namespace GamifyApp.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //TODO: Make this easier
            builder.RegisterType<HelloRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
