using CQRS.Core.Domain;

namespace CQRS.Core.Handlers
{
    public interface IEventSourcingHandler<T>
    {
        Task SendAsync(AggregateRoot aggregate);
        Task<T> GetByIdAsync(Guid id);
    }
}
