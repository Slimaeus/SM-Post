using CQRS.Core.Events;

namespace Post.Common.Events
{
    public class CommentRemovedEvent : BaseEvent
    {
        public CommentRemovedEvent(string type) : base(nameof(CommentRemovedEvent))
        {
        }
        public Guid CommentId { get; set; }
    }
}
