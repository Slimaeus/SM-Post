using CQRS.Core.Domain;
using CQRS.Core.Events;
using CQRS.Core.Infrastructure;

namespace Post.Cmd.Infrastructure.Stores
{
    public class EventStore : IEventStore
    {
        private readonly IEventStoreRepository _eventStoreRepository;
        public EventStore(IEventStoreRepository eventStoreRepository)
        {
            _eventStoreRepository = eventStoreRepository;
        }
        public Task<List<BaseEvent>> GetEventsAsync(Guid aggregateId)
        {
            throw new NotImplementedException();
        }

        public Task SaveEventAsync(Guid aggregateId, IEnumerable<BaseEvent> events, int expectedVersion)
        {
            throw new NotImplementedException();
        }
    }
}
