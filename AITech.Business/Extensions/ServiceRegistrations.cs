using AITech.Business.Services.AboutItemServices;
using AITech.Business.Services.AboutServices;
using AITech.Business.Services.BannerServices;
using AITech.Business.Services.CategoryServices;
using AITech.Business.Services.ChooseItemServices;
using AITech.Business.Services.ChooseServices;
using AITech.Business.Services.ContactServices;
using AITech.Business.Services.FAQServices;
using AITech.Business.Services.FeatureServices;
using AITech.Business.Services.ProjectServices;
using AITech.Business.Services.SocialServices;
using AITech.Business.Services.TeamWorkerServices;
using AITech.Business.Services.TestimonialServices;
using AITech.Business.Services.TokenServices;
using AITech.Business.Services.UserMessageServices;
using AITech.Business.Services.UserServices;
using Microsoft.Extensions.DependencyInjection;


namespace AITech.Business.Extensions
{
    public static class ServiceRegistrations

    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
           
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IAboutItemService, AboutItemService>();
            services.AddScoped<ISocialService, SocialService>();
            services.AddScoped<IFAQService, FAQService>();
            services.AddScoped<IChooseService, ChooseService>();
            services.AddScoped<IChooseItemService, ChooseItemService>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<ITeamWorkerService, TeamWorkerService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserMessageService, UserMessageService>();
            services.AddScoped<IContactService, ContactService>();

        }

    }
}

