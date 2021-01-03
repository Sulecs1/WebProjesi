using System.Collections.Generic;
using System.Threading.Tasks;
using BlogProjem.Entities.Concrete;

namespace BlogProjem.Business.Interfaces
{
    public interface ICommentService : IGenericService<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}
