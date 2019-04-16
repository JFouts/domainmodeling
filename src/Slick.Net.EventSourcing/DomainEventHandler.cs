﻿using System.Threading.Tasks;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventSourcing
{
    public abstract class DomainEventHandler<TAggregate, TEvent> : IDomainEventHandler<TAggregate, TEvent> where TEvent : IDomainEvent
    {
        public abstract Task HandleAsync(TAggregate aggregate, TEvent @event);

        async Task IDomainEventHandler<TAggregate>.HandleAsync(TAggregate aggregate, IDomainEvent @event)
        {
            if (@event.GetType() != typeof(TEvent))
                throw new InvalidDomainEventTypeException();

            await HandleAsync(aggregate, (TEvent)@event);
        }
    }
}