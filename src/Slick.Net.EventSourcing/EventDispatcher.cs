using System.Threading.Tasks;
using Slick.Net.Core;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventSourcing
{
    public class EventDispatcher<TAggregate> : IEventDispatcher<TAggregate> where TAggregate : AggregateRoot
    {
        private readonly IEventHandlerFactory<TAggregate> _eventHandlerFactory;

        public EventDispatcher(IEventHandlerFactory<TAggregate> eventHandlerFactory)
        {
            _eventHandlerFactory = eventHandlerFactory;
        }

        public async Task DispatchAsync(TAggregate aggregate, IDomainEvent @event)
        {
            var eventHandler = _eventHandlerFactory.CreateHandler(@event.GetType());
            await eventHandler.HandleAsync(aggregate, @event);
        }
    }
}
