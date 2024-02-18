using DataAceessLayer.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Batates.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Batates.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderProductConfiguration());

            modelBuilder.Entity<Category>().HasData(new Category() { ID = 1, Name = "Italian", Description = "Italian Food Category 123", ImageURL = "https://i.ibb.co/PZ03P9S/pizza.png" });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant() { ID = 1, Name = "RomaPizza", Description = "Roma Pizza for Italian Food!", State = State.Opened, ContactNo = "0114379314" });
            modelBuilder.Entity<Product>().HasData(new Product() { ID = 1, Name = "One Pizza Slice", Description = "Best Pizza slice in the world", Price = 9.99, ImageURL = "https://i.ibb.co/PZ03P9S/pizza.png", RestaurantID = 1 });
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = SD.Role_Admin, NormalizedName = SD.Role_Admin.ToUpper() },
                new IdentityRole() { Id = "d3c902cf-6b3e-4f66-9b82-c6a18a4ffa13", Name = SD.Role_Customer, NormalizedName = SD.Role_Customer.ToUpper() });
            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser()
                {
                    UserName = "admin@batates.com",
                    NormalizedUserName = "admin@batates".ToUpper(),
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    Email = "admin@batates.com",
                    NormalizedEmail = "admin@batates.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123@Abc")
                },
                new ApplicationUser()
                {
                    UserName = "customer@batates.com",
                    NormalizedUserName = "customer@batates".ToUpper(),
                    Id = "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                    Email = "customer@batates.com",
                    NormalizedEmail = "customer@batates.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123@Abc")
                }

                );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                { RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210", UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                 new IdentityUserRole<string>()
                 { RoleId = "d3c902cf-6b3e-4f66-9b82-c6a18a4ffa13", UserId = "2097f2ca-02a2-4b4f-97a0-1a7679151295" }
                );


            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }


        public virtual DbSet<Restaurant> Restaurant { get; set; }

    }
}
