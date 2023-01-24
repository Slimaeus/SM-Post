using Post.Common.DTOs;
using Post.Query.Domain.Enitities;

namespace Post.Query.Api.DTOs
{
    public class PostLookupResponse : BaseResponse
    {
        public List<PostEntity> Posts { get; set; }
    }
}
