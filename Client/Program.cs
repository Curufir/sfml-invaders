using Autofac;
using Client;
using Client.Services;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("./Logs/log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

ContainerBuilder builder = new();

builder.RegisterModule<ClientModule>();

using IContainer container = builder.Build();
using ILifetimeScope scope = container.BeginLifetimeScope();
{
    IDirectorService directorService = scope.Resolve<IDirectorService>();

    await directorService.Execute();
}

Console.WriteLine("Client terminated");