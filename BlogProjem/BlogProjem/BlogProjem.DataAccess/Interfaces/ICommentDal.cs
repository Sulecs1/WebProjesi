using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlogProjem.Entities.Concrete;

namespace BlogProjem.DataAccess.Interfaces
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}
