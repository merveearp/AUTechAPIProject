using AITech.WEBUI.Services.AboutItemServices;
using AITech.WEBUI.Services.AboutServices;
using AITech.WEBUI.Services.BannerServices;
using AITech.WEBUI.Services.CategoryServices;
using AITech.WEBUI.Services.ChooseItemServices;
using AITech.WEBUI.Services.ChooseServices;
using AITech.WEBUI.Services.ContactServices;
using AITech.WEBUI.Services.FAOServices;
using AITech.WEBUI.Services.FeatureServices;
using AITech.WEBUI.Services.GeminiServices;
using AITech.WEBUI.Services.ProjectService;
using AITech.WEBUI.Services.SocialServices;
using AITech.WEBUI.Services.TeamWorkerServices;
using AITech.WEBUI.Services.TestimonialServices;
using AITech.WEBUI.Services.UserMessageServices;
using AITech.WEBUI.Services.UserServices;
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
            services.AddScoped<IBannerService , BannerService>();
            services.AddScoped<IChooseService , ChooseService>();
            services.AddScoped<IChooseItemService , ChooseItemService>();
            services.AddScoped<IFAQService , FAQService>();
            services.AddScoped<IFeatureService , FeatureService>();
            services.AddScoped<ISocialService , SocialService>();
            services.AddScoped<IAboutService , AboutService>();
            services.AddScoped<IAboutItemService , AboutItemService>();
            services.AddScoped<ITeamWorkerService , TeamWorkerService>();
            services.AddScoped<ITestimonialService , TestimonialService>();
            services.AddScoped<IUserService , UserService>();
            services.AddScoped<IContactService , ContactService>();
            services.AddScoped<IUserMessageService , UserMessageService>();
            services.AddScoped<IGeminiService , GeminiService>();

            services.AddFluentValidationAutoValidation()
                    .AddFluentValidationClientsideAdapters()
                    .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
