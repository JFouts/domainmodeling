using System;
using System.Threading.Tasks;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventRepository
{
    public interface IEventSubscription
    {
        Task Subscribe<T>(Func<IDomainEvent, Task> eventHandler);
    }
}