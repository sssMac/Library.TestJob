using Library.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Library.Server.Configurations
{
    public static class DatabaseConfiguration
    {
        public static IServiceCollection DataBaseRegister(this IServiceCollection services, IConfiguration config)
        {

            services.AddDbContext<ApplicationContext>(options =>
                options.UseNpgsql(config["ConnectionStrings:DefaultConnection"]));

            return services;
        }
    }
}
