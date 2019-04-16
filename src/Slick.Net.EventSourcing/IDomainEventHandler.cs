using System.Threading.Tasks;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventSourcing
{
    public interface IDomainEventHandler<in TAggregate, in TEvent> : IDomainEventHandler<TAggregate> where TEvent : IDomainEvent
    {
        Task HandleAsync(TAggregate aggregate, TEvent @event);
    }

    public interface IDomainEventHandler<in T>
    {
        Task HandleAsync(T aggregate, IDomainEvent @event);
    }
}
