using Contracts;
using LoggerService;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Parser.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
         {
             options.AddPolicy("CorsPolicy", builder =>
             builder.AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader());
         });

        public static void ConfigureIISIntegration(this IServiceCollection services) => services.Configure<IISOptions>(options =>
         {
         });

        public static void ConfigureLoggerService(this IServiceCollection services) => services.AddTransient<ILoggerManager, LoggerManager>();

         public static void ConfigureSqlContext(this IServiceCollection services,
        IConfiguration configuration) =>
         services.AddDbContext<RepositoryContext>(opts =>
         opts.UseSqlite(configuration.GetConnectionString("sqlConnection"), b => b.MigrationsAssembly("Parser")));


        public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddTransient<IRepositoryManager, RepositoryManager>();


    }
}
