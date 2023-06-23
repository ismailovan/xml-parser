using Entities;
using Microsoft.Extensions.Configuration;
using System;
using WorkerXML;
using WorkerXML.Services;
using Parser.Extensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        var host = hostContext.Configuration;
        services.AddTransient<RepositoryContext>();
        services.AddDbContext<RepositoryContext>();
        services.AddTransient<MetDataService>();
       
        services.ConfigureLoggerService();
        //services.ConfigureSqlContext(host);
        //services.ConfigureRepositoryManager();
        services.AddAutoMapper(typeof(Startup));
        services.AddHostedService<Worker>();

    })
    .Build();

await host.RunAsync();
