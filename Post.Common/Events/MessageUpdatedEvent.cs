using CQRS.Core.Events;

namespace Post.Common.Events
{
    public class MessageUpdatedEvent : BaseEvent
    {
        public MessageUpdatedEvent(string type) : base(nameof(MessageUpdatedEvent))
        {
        }
        public string Message { get; set; }
    }
}
