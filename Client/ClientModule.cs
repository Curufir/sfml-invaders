using Autofac;
using Core;
using Client.Services;

namespace Client
{
    public class ClientModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            _ = builder.RegisterModule<CoreModule>();

            _ = builder.RegisterType<DirectorService>().As<IDirectorService>().SingleInstance();

            _ = builder.RegisterType<ClientTestService>().As<IClientTestService>().SingleInstance();

        }
    }
}