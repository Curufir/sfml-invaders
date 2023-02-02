using Autofac;
using Client.Services;

namespace Client
{
    public class ClientModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            _ = builder.Register(c => new ClientTestService()).As<IClientTestService>().SingleInstance();
        }
    }
}