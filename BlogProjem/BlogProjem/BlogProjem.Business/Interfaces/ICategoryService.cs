using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlogProjem.Entities.Concrete;

namespace BlogProjem.Business.Interfaces
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<Category>> GetAllSortedByIdAsync();
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
