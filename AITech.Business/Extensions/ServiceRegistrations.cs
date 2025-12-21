using AITech.Business.Services.AboutItemServices;
using AITech.Business.Services.BannerServices;
using AITech.Business.Services.CategoryServices;
using AITech.Business.Services.ChooseServices;
using AITech.Business.Services.FAQServices;
using AITech.Business.Services.ProjectServices;
using AITech.Business.Services.SocialServices;
using AITech.Business.Services.TestimonialServices;
using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.Repositories.BannerRepositories;
using AITech.DataAccess.Repositories.CategoryRepositories;
using AITech.DataAccess.Repositories.ProjectRepositories;
using AITech.DataAccess.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            services.AddScoped<ITestimonialService, TestimonialService>();
        }

    }
}

