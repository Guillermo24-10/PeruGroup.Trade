using PeruGroup.Trade.Domain.Commons;
using PeruGroup.Trade.Domain.Enums;

namespace PeruGroup.Trade.Domain.Events
{
    public class OrderUpdatedEvent : BaseEvent
    {
        public string? Id { get; set; }
        public int Quanty { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; } = string.Empty;
        public string? Text { get; set; }
    }
}
