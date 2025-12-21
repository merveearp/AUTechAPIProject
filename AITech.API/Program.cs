using AITech.Business.Extensions;
using AITech.DataAccess.Context;
using AITech.DataAccess.Extensions;
using AITech.DataAccess.Interceptors;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDataAccessServices();
builder.Services.AddBusinessServices();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
    opt.AddInterceptors(new AuditDbContextInterceptor());
});
builder.Services.AddControllers();


builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
