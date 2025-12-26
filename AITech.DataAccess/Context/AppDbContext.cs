using AITech.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Context
{
    public class AppDbContext :IdentityDbContext<AppUser,AppRole,int>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        
        }
       
        //pluralize çoğullaştırma
        //singularize tekilleştirme
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutItem> AboutItems { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Choose> Chooses { get; set; }
        public DbSet<ChooseItem> ChooseItems { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TeamWorker> TeamWorkers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
    }
}
