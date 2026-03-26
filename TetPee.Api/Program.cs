using Microsoft.EntityFrameworkCore;
using TetPee.Api.Middlewares;
using TetPee.Repository;
using TetPee.Service.Identity;

using UserService = TetPee.Service.User;

using IServiceCategory = TetPee.Service.Category.IService;
using ServiceCategory = TetPee.Service.Category.Service;


using JwtService = TetPee.Service.JwtService;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddScoped<UserService.IService, UserService.Service>(); 
builder.Services.AddScoped<JwtService.IJwtServices, JwtService.JwtServices>();

builder.Services.AddScoped<IServiceCategory, ServiceCategory>(); 
builder.Services.AddScoped<IServiceIdentity,  ServiceIdentity>();
builder.Services.AddScoped<TetPee.Service.Seller.IService, TetPee.Service.Seller.Service>();
//để tự động inject vào viết cho máy hiểu inject vào cho mình 

// SingleTon, Scope, Transient
//đó giờ hiểu câu lệnh này chưa
builder.Services.AddTransient<GlobalExceptionHandlerMiddleware>();
var app = builder.Build();

//sài là sau dòng trên này đó
app.UseMiddleware<GlobalExceptionHandlerMiddleware>();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();