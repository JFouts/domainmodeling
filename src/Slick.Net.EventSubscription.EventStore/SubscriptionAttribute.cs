using System;

namespace Slick.Net.EventSubscription.EventStore
{
    public class SubscriptionAttribute : Attribute
    {
        public string StreamName { get; }

        public SubscriptionAttribute(string streamName)
        {
            StreamName = streamName;
        }
    }
}