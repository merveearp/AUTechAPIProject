using AITech.WEBUI.Services.CategoryServices;

namespace AITech.WEBUI.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddUIService(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService , CategoryService>();
        }
    }
}
