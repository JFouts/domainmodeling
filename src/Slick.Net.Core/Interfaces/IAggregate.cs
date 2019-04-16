using System.Threading.Tasks;

namespace Slick.Net.Core.Interfaces
{
    public interface IAggregate<out TAggregate> where TAggregate : AggregateRoot
    {
        TAggregate State { get; }
        Task SaveAsync();
    }
}
