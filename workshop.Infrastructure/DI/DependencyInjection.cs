using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using workshop.Application.Common.Interface;
using workshop.Infrastructure.Persistence;
using workshop.Infrastructure.Services;

namespace workshop.Infrastructure.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(
                options => options.UseNpgsql(configuration.GetConnectionString("WorkshopDatabasePostgreSQL"),
                b => b.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName)),
                ServiceLifetime.Transient);

            services.AddIdentityCore<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
            }).AddEntityFrameworkStores<ApplicationDBContext>();

            services.AddScoped<IApplicationDBContext>(provider => (IApplicationDBContext)provider.GetServices<ApplicationDBContext>());
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IAuthentication, AuthenticationService>();
            return services;
        }
    }
}
