using Slick.Net.Core;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventSourcing.AspNetCore
{
    public interface IAggregateBuilder<in TAggregate> where TAggregate : AggregateRoot
    {
        IAggregateBuilder<TAggregate> AddEvent<TEvent>() where TEvent : IDomainEvent;
    }
}