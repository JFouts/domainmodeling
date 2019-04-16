using System;
using System.Collections.Generic;
using Slick.Net.Core;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventSourcing
{
    public interface IAggregateFactory<TAggregate> where TAggregate : AggregateRoot, new()
    {
        EventSourcedAggregate<TAggregate> CreateUnrecordedAggregate(Guid id);
        EventSourcedAggregate<TAggregate> CreateRecordedAggregate(Guid id, long version, IEnumerable<IDomainEvent> events);
    }
}