using System;
using System.Threading.Tasks;

namespace Slick.Net.Core.Interfaces
{
    public interface IAggregateRepository<TAggregate> where TAggregate : AggregateRoot
    {
        IAggregate<TAggregate> Instantiate(Guid id);
        Task<IAggregate<TAggregate>> RetrieveAsync(Guid id);
    }
}
