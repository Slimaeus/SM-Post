using CQRS.Core.Events;

namespace CQRS.Core.Domain
{
    public interface IEventStoreRepository
    {
        Task SendAsync(EventModel @event);
        Task<List<EventModel>> FindByAggredateId(Guid aggregateId);
        Task<List<EventModel>> FindAllAsync();
    }
}
