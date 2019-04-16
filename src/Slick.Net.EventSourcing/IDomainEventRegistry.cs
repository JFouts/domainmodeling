using System;
using Slick.Net.Core;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventSourcing
{
    public interface IDomainEventRegistry<out TAggregate> where TAggregate : AggregateRoot
    {
        Type GetHandlerType(Type eventType);

        void RegisterHandler<TEvent, THandler>()
            where TEvent : IDomainEvent
            where THandler : IDomainEventHandler<TAggregate, TEvent>;
    }
}
