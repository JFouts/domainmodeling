using System.Threading.Tasks;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventSourcing
{
    public interface IEventDispatcher<in T>
    {
        Task DispatchAsync(T aggregate, IDomainEvent @event);
    }
}
