using System;

namespace Slick.Net.Core.Interfaces
{
    public interface IDomainEvent
    {
        Guid Id { get; }
        DateTime OccurredAtUtc { get; }
        DateTime ProcessedAtUtc { get; }
    }
}
