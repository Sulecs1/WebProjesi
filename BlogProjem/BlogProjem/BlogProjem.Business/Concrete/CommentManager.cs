using System.Collections.Generic;
using System.Threading.Tasks;
using BlogProjem.Business.Interfaces;
using BlogProjem.DataAccess.Interfaces;
using BlogProjem.Entities.Concrete;

namespace BlogProjem.Business.Concrete
{
    public class CommentManager : GenericManager<Comment>, ICommentService
    {

        private readonly ICommentDal _commentDal;
        public CommentManager(IGenericDal<Comment> genericDal, ICommentDal commentDal) : base(genericDal)
        {
            _commentDal = commentDal;

        }

        public Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId)
        {
            return _commentDal.GetAllWithSubCommentsAsync(blogId, parentId);
        }
    }
}
