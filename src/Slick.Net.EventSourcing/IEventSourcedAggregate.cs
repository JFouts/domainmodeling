using System.Collections.Generic;
using System.Threading.Tasks;
using Slick.Net.Core;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventSourcing
{
    public interface IEventSourcedAggregate<out T> : IAggregate<T> where T : AggregateRoot
    {
        IEnumerable<IDomainEvent> UnrecordedEvents { get; }
        Task FireEventAsync(IDomainEvent @event);
        Task DispatchEventAsync(IDomainEvent @event);
    }
}