//using Contracts;
using Entities;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;
using Parser;
using Parser.Extensions;


public class Startup
{
    public Startup(IConfigurationRoot configuration)
    {
        LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
        Configuration = configuration;
    }

    public IConfigurationRoot Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.ConfigureCors();
        services.ConfigureIISIntegration();
        services.ConfigureLoggerService();
        services.ConfigureSqlContext(Configuration);
        services.AddTransient<RepositoryContext>();
        services.AddHostedService<WorkerXML>();
        services.ConfigureRepositoryManager();
        services.AddAutoMapper(typeof(Startup));
        services.AddTransient<MetDataService>();
        services.AddControllers(config =>
        {
            config.RespectBrowserAcceptHeader = true;
        }).AddXmlDataContractSerializerFormatters();


    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseCors("CorsPolicy");
        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.All
        });
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

    }
}