using DataAceessLayer.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Batates.Models;

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

            modelBuilder.Entity<Category>().HasData(new Category() { ID = 1, Name="Italian", Description="Italian Food Category 123", ImageURL= "https://i.ibb.co/PZ03P9S/pizza.png" });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant() { ID = 1, Name ="RomaPizza", Description="Roma Pizza for Italian Food!", State=State.Opened, ContactNo="0114379314" });
            modelBuilder.Entity<Product>().HasData(new Product() { ID = 1, Name = "One Pizza Slice", Description = "Best Pizza slice in the world", Price = 9.99,ImageURL = "https://i.ibb.co/PZ03P9S/pizza.png", RestaurantID = 1 });

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }
    }
}
