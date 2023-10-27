using Books.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Books.Web.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMyDbContect(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlite(configuration.GetConnectionString("DbConnection"));
        });

        return services;
    }
}
