using PeruGroup.Trade.Domain.Commons;

namespace PeruGroup.Trade.Domain.Events
{
    public class OrderCanceledEnvent : BaseEvent
    {
        public int Id { get; set; }
    }
}
