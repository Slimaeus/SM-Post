using CQRS.Core.Domain;

namespace Post.Cmd.Domain.Aggregates
{
    public class PostAggregate : AggregateRoot
    {
        private bool _active;
        private string _author;
        private readonly Dictionary<Guid, Tuple<string, string>> _comments = new Dictionary<Guid, Tuple<string, string>>();
        public bool Active
        {
            get => _active; set => _active = value;
        }
    }
}
