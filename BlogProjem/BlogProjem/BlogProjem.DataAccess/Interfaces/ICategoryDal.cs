using System.Collections.Generic;
using System.Threading.Tasks;
using BlogProjem.Entities.Concrete;

namespace BlogProjem.DataAccess.Interfaces
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
