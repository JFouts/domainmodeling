using System;

namespace Slick.Net.EventSourcing
{
    public interface IEventHandlerFactory<TAggregate>
    {
        IDomainEventHandler<TAggregate> CreateHandler(Type eventType);
    }
}
