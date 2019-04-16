using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventRepository
{
    public interface IEventRepository
    {
        Task SaveNewStreamEventsAsync<T>(Guid id, IEnumerable<IDomainEvent> domainEvents);
        Task SaveEventsAsync<T>(Guid id, IEnumerable<IDomainEvent> domainEvents, long aggregateVersion);
        Task<AggregateEventList> RetriveEventsAsync<T>(Guid id);
    }
}
