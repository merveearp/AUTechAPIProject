using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.Repositories.BannerRepositories;
using AITech.DataAccess.Repositories.CategoryRepositories;
using AITech.DataAccess.Repositories.ChooseItemRepositories;
using AITech.DataAccess.Repositories.ChooseRepositories;
using AITech.DataAccess.Repositories.ContactRespositories;
using AITech.DataAccess.Repositories.FAQRepositories;
using AITech.DataAccess.Repositories.FeatureRepositories;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.DataAccess.Repositories.ProjectRepositories;
using AITech.DataAccess.Repositories.SocialRepositories;
using AITech.DataAccess.Repositories.TeamWorkerRepositories;
using AITech.DataAccess.Repositories.TestimonialRepositories;
using AITech.DataAccess.Repositories.UserMessageRepositories;
using AITech.DataAccess.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProjectRepository ,ProjectRepository>();
            services.AddScoped<ICategoryRepository  ,CategoryRepository>();
            services.AddScoped<IBannerRepository  ,BannerRepository>();
            services.AddScoped<IAboutItemRepository  ,AboutItemRepository>();
            services.AddScoped<IFAQRepository  ,FAQRepository>();
            services.AddScoped<ISocialRepository  ,SocialRepository>();
            services.AddScoped<ITestimonialRepository  ,TestimonialRepository>();
            services.AddScoped<IChooseItemRepository  ,ChooseItemRepository>();
            services.AddScoped<IChooseRepository  ,ChooseRepository>();
            services.AddScoped<IFeatureRepository  ,FeatureRepository>();
            services.AddScoped<ITeamWorkerRepository  ,TeamWorkerRepository>();
            services.AddScoped<IAboutRepository  ,AboutRepository>();
            services.AddScoped<IContactRepository  ,ContactRepository>();
            services.AddScoped<IUserMessageRepository  ,UserMessageRepository>();
           
        }
    }
}
