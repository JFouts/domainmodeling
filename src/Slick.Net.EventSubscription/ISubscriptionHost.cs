using System;
using System.Threading.Tasks;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventSubscription
{
    public interface ISubscriptionHost
    {
        Task StartAsync();
        void Subscribe(IEventStream stream, Func<IDomainEvent, Task> eventHandler);
    }
}