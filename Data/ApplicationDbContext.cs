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

            //Seeding2 test = new Seeding2();

            modelBuilder.Entity<Category>().HasData(SeedData.CategoryList());
            modelBuilder.Entity<Restaurant>().HasData(SeedData.RestaurantList());
            //modelBuilder.Entity<Restaurant>().HasData(test.Restaurants);
            modelBuilder.Entity<Product>().HasData(SeedData.ProductsList());
            modelBuilder.Entity<IdentityRole>().HasData(SeedData.RoleList());
            modelBuilder.Entity<ApplicationUser>().HasData(SeedData.UsersList());
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(SeedData.UserRoleList());


            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }

        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<Category> Category { get; set; } 

    }
}
