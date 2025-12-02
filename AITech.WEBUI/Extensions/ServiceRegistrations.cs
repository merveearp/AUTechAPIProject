using AITech.WEBUI.Services.CategoryServices;
using AITech.WEBUI.Services.ProjectService;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace AITech.WEBUI.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddUIService(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService , CategoryService>();
            services.AddScoped<IProjectService , ProjectService>();

            services.AddFluentValidationAutoValidation()
                    .AddFluentValidationClientsideAdapters()
                    .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
