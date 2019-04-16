using System;

namespace Slick.Net.EventRepository.EventStore.NamingConention
{
    public interface IStreamNamingConvention
    {
        string GetStreamName<T>();
        string GetStreamName(Type type);
    }
}