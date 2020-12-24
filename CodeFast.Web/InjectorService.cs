using CodeFast.Web.Manager.Implementation;
using CodeFast.Web.Manager.Interface;
using CodeFast.Web.Repository;
using CodeFast.Web.Repository.Implementation;
using CodeFast.Web.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodeFast.Web
{
    public static class InjectorService
    {
        public static void RegisterService(this IServiceCollection services, IConfiguration configuration)
        {

            #region DbContext Alias
            services.AddDbContext<EfDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DotNet5DBDbContext"), b => b.MigrationsAssembly("CodeFast.Web")));
            services.AddScoped<DbContext, EfDbContext>();

            #endregion

            #region Repository Alias
            services.AddScoped<IStudentRepository, StudentRepository>();

            #endregion

            #region Manager Alias
            services.AddScoped<IStudentManager, StudentManager>();

            #endregion
        }
    }
}