using Library.BLL.Interfaces;
using Library.BLL.Services;
using Library.DAL.Interfaces;
using Library.DAL.Repositories;
using System.Text.Json.Serialization;

namespace Library.Server.Configurations
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection ServicesRegister(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddAntiforgery(o => o.HeaderName = "X-XSRF-TOKEN");

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ILibraryService, LibraryService>();
            services.AddScoped<IJwtService, JwtService>();

            return services;
        }


    }
}
