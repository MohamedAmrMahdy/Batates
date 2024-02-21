using Microsoft.EntityFrameworkCore;
using Batates.Models;

namespace DataAceessLayer.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Order> builder)
        {
            builder.HasMany(o => o.Products).WithMany(o => o.Orders).UsingEntity<OrderProduct>(
                l => l.HasOne(op => op.Product).WithMany(p => p.OrderProducts).HasForeignKey(op => op.ProductID),
                r => r.HasOne(op => op.Order).WithMany(o => o.OrderProducts).HasForeignKey(op => op.OrderID)
                );
        }
    }
}
