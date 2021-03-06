﻿using System;
using System.Collections.Generic;
using DomainModeling.Core;
using DomainModeling.Core.Interfaces;

namespace DomainModeling.EventSourcing
{
    public class AggregateFactory<TAggregate> : IAggregateFactory<TAggregate> where TAggregate : AggregateRoot, new()
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IEventDispatcher<TAggregate> _eventDispatcher;

        public AggregateFactory(IServiceProvider serviceProvider, IEventDispatcher<TAggregate> eventDispatcher)
        {
            _serviceProvider = serviceProvider;
            _eventDispatcher = eventDispatcher;
        }

        public EventSourcedAggregate<TAggregate> CreateUnrecordedAggregate(Guid id)
        {
            var repo = _serviceProvider.GetService(typeof(IEventSourcedAggregateRepository<TAggregate>)) as IEventSourcedAggregateRepository<TAggregate>;
            return new UnrecordedAggregate<TAggregate>(id, repo, _eventDispatcher);
        }

        public EventSourcedAggregate<TAggregate> CreateRecordedAggregate(Guid id, long version, IEnumerable<IDomainEvent> events)
        {
            var repo = _serviceProvider.GetService(typeof(IEventSourcedAggregateRepository<TAggregate>)) as IEventSourcedAggregateRepository<TAggregate>;
            return new RecordedAggregate<TAggregate>(id, version, events, repo, _eventDispatcher);
        }
    }
}
