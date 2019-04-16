using System;
using System.Threading.Tasks;
using Slick.Net.Core;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventSourcing
{
    public interface IEventSourcedAggregateRepository<TAggregate>  : IAggregateRepository<TAggregate> where TAggregate : AggregateRoot, new()
    {
        new IEventSourcedAggregate<TAggregate> Instantiate(Guid id);
        new Task<IEventSourcedAggregate<TAggregate>> RetrieveAsync(Guid id);
        Task SaveUnrecordedAggregateAsync(UnrecordedAggregate<TAggregate> unrecordedAggregate);
        Task SaveRecordedAggregateAsync(RecordedAggregate<TAggregate> recordedAggregate);
    }
}
