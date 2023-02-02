using Autofac;
using Core.Services;

namespace Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            _ = builder.Register(c => new CoreTestService()).As<ICoreTestService>().SingleInstance();
        }
    }
}