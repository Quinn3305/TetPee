using Microsoft.EntityFrameworkCore;
using TetPee.Api.Extensions;
using TetPee.Api.Middlewares;
using TetPee.Repository;
using UserService = TetPee.Service.User;
using CategoryService = TetPee.Service.Category;
using SellerService = TetPee.Service.Seller;
using IdentityService = TetPee.Service.Identity;
using ProductService = TetPee.Service.Product;
using JwtService = TetPee.Service.JwtService;
using CartService = TetPee.Service.Cart;
using MediaService = TetPee.Service.MediaService;
using CloudinaryService = TetPee.Service.CloudinaryService;
using MailService = TetPee.Service.MailService;
using OrderService = TetPee.Service.Order;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddHttpContextAccessor();//Them 1/4
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddJwtServices(builder.Configuration);
builder.Services.AddSwaggerServices();

builder.Services.AddScoped<UserService.IService, UserService.Service>(); 
builder.Services.AddScoped<CategoryService.IService, CategoryService.Service>();
builder.Services.AddScoped<ProductService.IService, ProductService.Service>();
builder.Services.AddScoped<SellerService.IService,  SellerService.Service>();
builder.Services.AddScoped<MediaService.IService,  CloudinaryService.Service>(); 
builder.Services.AddScoped<JwtService.IJwtServices, JwtService.JwtServices>();
builder.Services.AddScoped<IdentityService.IService,  IdentityService.Service>();
builder.Services.AddScoped<CartService.IService,  CartService.Service>();
builder.Services.AddScoped<OrderService.IService,  OrderService.Service>();
builder.Services.AddScoped<MailService.IService,  MailService.Service>();

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
    app.UseSwaggerAPI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();