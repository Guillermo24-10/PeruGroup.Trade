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
                    TransactTime = DateTime.Now,
                    Quanty = 1000,
                    Type = Domain.Enums.OrderType.LIMIT,
                    Price = 150.00m
                },
                new Order
                {
                    Id = 2,
                    Symbol = "GOOGL",
                    Side = Domain.Enums.OrderSide.SELL,
                    TransactTime = DateTime.Now,
                    Quanty = 500,
                    Type = Domain.Enums.OrderType.LIMIT,
                    Price = 2800.00m
                },
                new Order
                {
                    Id = 3,
                    Symbol = "MSFT",
                    Side = Domain.Enums.OrderSide.SELL,
                    TransactTime = DateTime.Now,
                    Quanty = 750,
                    Type = Domain.Enums.OrderType.MARKET,
                    Price = 300.00m
                },
                new Order
                {
                    Id = 4,
                    Symbol = "AMZN",
                    Side = Domain.Enums.OrderSide.SELL,
                    TransactTime = DateTime.Now,
                    Quanty = 200,
                    Type = Domain.Enums.OrderType.MARKET,
                    Price = 3500.00m
                });
        }
    }
}
