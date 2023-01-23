using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Post.Query.Domain.Enitities
{
    [Table("Post")]
    public class PostEntity
    {
        [Key]
        public Guid PostId { get; set; }
        public string Author { get; set; }
    }
}
