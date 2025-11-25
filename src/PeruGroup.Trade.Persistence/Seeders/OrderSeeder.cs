using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeruGroup.Trade.Domain.Entities;

namespace PeruGroup.Trade.Persistence.Seeders
{
    public class OrderSeeder : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order
                {
                    Id = 1,
                    Symbol = "AAPL",
                    Side = Domain.Enums.OrderSide.BUY,
                    TransactTime = new DateTime(2025, 01, 01, 0, 0, 0),
                    Quanty = 1000,
                    Type = Domain.Enums.OrderType.LIMIT,
                    Price = 150.00m,
                    Currency = "USD",
                    Text = "Initial order for AAPL",
                    Created = new DateTime(2025, 01, 01, 0, 0, 0),
                    CreatedBy = "System"    
                },
                new Order
                {
                    Id = 2,
                    Symbol = "GOOGL",
                    Side = Domain.Enums.OrderSide.SELL,
                    TransactTime = new DateTime(2025, 01, 01, 0, 0, 0),
                    Quanty = 500,
                    Type = Domain.Enums.OrderType.LIMIT,
                    Price = 2800.00m,
                    Currency = "USD",
                    Text = "Initial order for GOOGL",   
                    Created = new DateTime(2025, 01, 01, 0, 0, 0),
                    CreatedBy = "System"
                },
                new Order
                {
                    Id = 3,
                    Symbol = "MSFT",
                    Side = Domain.Enums.OrderSide.SELL,
                    TransactTime = new DateTime(2025, 01, 01, 0, 0, 0),
                    Quanty = 750,
                    Type = Domain.Enums.OrderType.MARKET,
                    Price = 300.00m,
                    Currency = "USD",   
                    Text = "Initial order for MSFT",
                    Created = new DateTime(2025, 01, 01, 0, 0, 0),
                    CreatedBy = "System"
                },
                new Order
                {
                    Id = 4,
                    Symbol = "AMZN",
                    Side = Domain.Enums.OrderSide.SELL,
                    TransactTime = new DateTime(2025, 01, 01, 0, 0, 0),
                    Quanty = 200,
                    Type = Domain.Enums.OrderType.MARKET,
                    Price = 3500.00m,
                    Currency = "USD",
                    Text = "Initial order for AMZN",
                    Created = new DateTime(2025, 01, 01, 0, 0, 0),
                    CreatedBy = "System"
                });
        }
    }
}
