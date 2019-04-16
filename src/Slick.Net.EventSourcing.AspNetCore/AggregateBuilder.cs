using System;
using System.Collections.Generic;
using Slick.Net.Core;
using Slick.Net.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Slick.Net.EventSourcing.AspNetCore
{
    public class AggregateBuilder<TAggregate> : IAggregateBuilder<TAggregate> where TAggregate : AggregateRoot, new()
    {
        private readonly IServiceCollection _services;
        private readonly List<Action<DomainEventRegistry<TAggregate>>> _eventRegisters = new List<Action<DomainEventRegistry<TAggregate>>>();

        public AggregateBuilder(IServiceCollection services)
        {
            _services = services;
        }

        public IAggregateBuilder<TAggregate> AddAggregate()
        {
            _services.AddSingleton(CreateRegistry);
            return this;
        }

        public IAggregateBuilder<TAggregate> AddEvent<TEvent>() where TEvent : IDomainEvent
        {
            _eventRegisters.Add(x => x.RegisterHandler<TEvent, IDomainEventHandler<TAggregate, TEvent>>());
            return this;
        }

        private IDomainEventRegistry<TAggregate> CreateRegistry(IServiceProvider serviceProvider)
        {
            var registry = new DomainEventRegistry<TAggregate>();
            ApplyEventRegisters(registry);
            return registry;
        }

        private void ApplyEventRegisters(DomainEventRegistry<TAggregate> registry)
        {
            foreach (var eventRegister in _eventRegisters)
                eventRegister(registry);
        }
    }
}