using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;
using Batates.Repo.Repo;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Batates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();

            // Reposositories
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
 
            builder.Services.AddScoped<ICartRepository, CartRepository>();
            builder.Services.AddScoped<IWithlistRepository, WishlistRepository>();

            
          builder.Services.AddScoped<ICartProductRepository, CartProductRepository>();
          builder.Services.AddScoped<IWishedItemRepository, WishedItemRepository>();


            builder.Services.AddAuthentication().AddMicrosoftAccount(options =>
            {
                // Authentication made as adviced by .NET Docs
                // https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/microsoft-logins?view=aspnetcore-6.0#store-the-microsoft-client-id-and-secret

                options.ClientId = configuration["Authentication:Microsoft:ClientId"];
                options.ClientSecret = configuration["Authentication:Microsoft:ClientSecret"];

                // Small code snippet for people who have several accounts (and switch between them)
                options.Events = new OAuthEvents
                {
                    OnRedirectToAuthorizationEndpoint = context =>
                    {
                        context.Response.Redirect(context.RedirectUri + "&prompt=select_account");
                        return Task.CompletedTask;
                    }
                };
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
