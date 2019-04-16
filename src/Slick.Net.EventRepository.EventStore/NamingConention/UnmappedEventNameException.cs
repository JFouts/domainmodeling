using System;

namespace Slick.Net.EventRepository.EventStore.NamingConention
{
    public class UnmappedEventNameException : Exception
    {
        public string EventName { get; }

        public UnmappedEventNameException(string eventName)
        {
            EventName = eventName;
        }
    }
}