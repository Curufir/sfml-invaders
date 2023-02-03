using Autofac;
using Client;
using Client.Services;

ContainerBuilder builder = new();

builder.RegisterModule<ClientModule>();

using IContainer container = builder.Build();
using ILifetimeScope scope = container.BeginLifetimeScope();
{
    IDirectorService directorService = scope.Resolve<IDirectorService>();

    await directorService.Execute();
}

Console.WriteLine("Client terminated");