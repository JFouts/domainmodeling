namespace Slick.Net.EventRepository.EventStore
{
    public static class NamingConvention
    {
        public static IEventStoreNamingConvention Literal => new LiteralEventStoreNamingConvention();
    }
}
