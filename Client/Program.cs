using Autofac;
using Client;
using Client.Services;
using Core;
using Core.Services;

ContainerBuilder builder = new();

builder.RegisterModule<CoreModule>();
builder.RegisterModule<ClientModule>();

using IContainer container = builder.Build();
using ILifetimeScope scope = container.BeginLifetimeScope();
{
    ICoreTestService coreTestService = scope.Resolve<ICoreTestService>();
    coreTestService.Test();

    IClientTestService clientTestService = scope.Resolve<IClientTestService>();
    clientTestService.Test();
}

Console.WriteLine("All done");