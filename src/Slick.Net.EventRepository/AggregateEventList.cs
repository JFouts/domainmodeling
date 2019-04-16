using System.Collections.Generic;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.EventRepository
{
    public class AggregateEventList
    {
        public long AggregateVersion { get; set; }
        public IEnumerable<IDomainEvent> DomainEvents { get; set; }
    }
}
