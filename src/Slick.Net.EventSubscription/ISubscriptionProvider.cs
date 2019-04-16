using System.Collections.Generic;

namespace Slick.Net.EventSubscription
{
    public interface ISubscriptionProvider
    {
        IEnumerable<SubscriptionDetail> GetSubscriptionDetails();
    }
}