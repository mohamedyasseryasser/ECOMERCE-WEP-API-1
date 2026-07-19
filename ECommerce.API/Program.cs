using ECommerce.Domain.Models;
using ECommerce.Domain.Interfaces;
using ECommerce.Infrastructure.Repositories;
using ECommerce.Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ECommerce.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            // Swagger + JWT Configuration
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "E-Commerce Clean Architecture API",
                    Version = "v1"
                });

                c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Description = "Enter your token: Bearer {your token}"
                });

                c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
                {
                    {
                        new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                        {
                            Reference = new Microsoft.OpenApi.Models.OpenApiReference
                            {
                                Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            // Database Context
            builder.Services.AddDbContext<context>(option =>
                option.UseSqlServer(builder.Configuration.GetConnectionString("e-comerce"))
            );

            // Identity Setup
            builder.Services.AddIdentity<applicationuser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
            }).AddEntityFrameworkStores<context>();

            // CORS Policy
            builder.Services.AddCors(option =>
            {
                option.AddPolicy("employee", corspolicybuilder =>
                {
                    corspolicybuilder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            // Authentication JWT
            builder.Services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = builder.Configuration["JWT:Issuer"] ?? "http://localhost:5064/",
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["JWT:Audience"] ?? "http://localhost:4200/",
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(builder.Configuration["JWT:secret"] ?? "YourSuperSecretKeyGoesHere")
                    )
                };
            });

            // Dependency Injection - Repositories
            builder.Services.AddScoped<IAuth, Auth>();
            builder.Services.AddScoped<IUser, User>();
            builder.Services.AddScoped<ICategoryReprosity, Categoryreprosity>();
            builder.Services.AddScoped<Iimagesreprosity, Imagesreprosity>();
            builder.Services.AddScoped<IsubCategoryReprosity, SubCategoryReprosity>();
            builder.Services.AddScoped<Iproductreprosity, Productreprosity>();
            builder.Services.AddScoped<Icartreprosity, cartreprosity>();
            builder.Services.AddScoped<Iorderreprosity, orderreprosity>();
            builder.Services.AddScoped<ICopounereprosity, Copounereprosity>();

            // Data Protection
            var keysPath = Path.Combine(builder.Environment.ContentRootPath, "DataProtectionKeys");
            if (!Directory.Exists(keysPath)) Directory.CreateDirectory(keysPath);

            builder.Services.AddDataProtection()
                .PersistKeysToFileSystem(new DirectoryInfo(keysPath))
                .SetApplicationName("ECommerceApi");

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "E-Commerce API V1");
                c.RoutePrefix = string.Empty; // Set Swagger as the root page
            });

            app.UseStaticFiles();
            app.UseCors("employee");
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
